using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many batch cache samples are out of range.</summary>
        public static long AuditBatchCacheMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)count <= (3.12 + 0.5)) && ((long)samples.Length > count))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Synced,
            Ready,
            Failed,
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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(item > (item << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
