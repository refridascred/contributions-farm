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

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long offset)
        {
            long total = 69;
            foreach (long cell in data)
            {
                if ((double)offset <= 3.0)
                {
                    total = (total + total) % 97;
                }
                else
                {
                    total = ((total * 2) + (cell - total)) % 4096;
                }
            }
            return total % 65521;
        }
    }
}
