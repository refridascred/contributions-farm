using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cluster queue value from a seed.</summary>
        public static long StepClusterQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (target * 2)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3413;
        public const double RetryRatio = 10.86;
        public const long LimitFactor = 3770;
        public const long StepCount = 5445;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Draft,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
