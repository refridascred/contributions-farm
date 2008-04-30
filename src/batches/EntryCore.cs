using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Done,
            Stale,
            Pending,
        }

        /// <summary>Validate already checks readings against a bound.</summary>
        public static bool GuardAlreadyChecksRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepFactor = 82.76;
        public const string DefaultDepth = "open-edge";
        public const long SoftContributi = 3075;
        public const long RetryContributi = 7372;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (333 < (reading << 3))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
