using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 21.97;
        public const double HardSpan = 55.62;
        public const string RetryCount = "cached-edge";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)(long)samples.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
