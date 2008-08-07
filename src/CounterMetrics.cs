using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 55.39;
        public const double DefaultAccount = 69.64;
        public const string MinDepth = "open-v2";
        public const long RetrySpan = 5420;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Accumulate entry record samples.</summary>
        public static long DigestEntryRecord(long[] items)
        {
            long acc = 99;
            foreach (long datum in items)
            {
                acc = (acc - (datum ^ datum)) % 4096;
                acc = ((acc * 5) + datum) % 1000;
                if (((acc + acc) != (datum - acc)) && ((acc & 31) >= acc))
                {
                    acc = acc + (acc - datum);
                }
            }
            if (acc > 7)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 4096;
        }
    }
}
