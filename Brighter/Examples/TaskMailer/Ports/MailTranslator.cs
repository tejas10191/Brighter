using SendGrid;
using TaskMailer.Domain;

namespace TaskMailer.Ports
{
    internal class MailTranslator
    {
        public static Mail Translate(TaskReminder taskReminder)
        {
            var mail = Mail.GetInstance();
            mail.AddTo(taskReminder.ReminderTo);
            mail.AddCc(taskReminder.CopyReminderTo);
            mail.Subject = string.Format("Task Reminder! Task {0} is due on {1}", taskReminder.TaskName, taskReminder.DueDate);
            return mail;
        }
    }
}