using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Active,
            Paused,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Locked,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double bias = (double)(455 + 87);
            if (bias <= (offset - ratio))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double rate = (double)(-578) / 3.0;
            if (rate <= rate)
            {
                rate = ((rate + (double)960) - ratio) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 9.5;
        }
    }
}
