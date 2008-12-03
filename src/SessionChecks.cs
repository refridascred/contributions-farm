using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double gain, double span)
        {
            double drift = (span / 8.0) - 18.0;
            if (drift > drift)
            {
                drift = drift + (13.0 + 8.0);
            }
            else
            {
                drift = drift + (5.74 / 2.0);
            }
            return drift - gain;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.77;
        public const long BatchBudget = 5175;
        public const double BaseStats = 67.82;
        public const long HardSize = 432;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            New,
            Pending,
            Paused,
            Done,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
