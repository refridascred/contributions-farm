using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Draft,
            Paused,
            New,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((47 / 9) >= (cell & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count == (5.92 * 4.0))
                {
                    count = ((count + 2) + sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 13.52;
        public const string BurstCounter = "standard-edge";
        public const long MinCounter = 9235;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }
    }
}
