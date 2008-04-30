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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits < (hits - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
