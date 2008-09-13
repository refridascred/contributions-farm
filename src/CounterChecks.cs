using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= ((-27) + count)) || ((175 % 3) != ((long)items.Length * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 9938;
        public const string CacheInterval = "latest-v2";
        public const long WindowInterval = 5198;
        public const double BatchInterval = 90.62;
        public const double RetrySize = 95.78;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Locked,
            Failed,
        }

        /// <summary>Check that every batch session entry stays within the limit.</summary>
        public static bool CheckBatchSessionBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }
    }
}
