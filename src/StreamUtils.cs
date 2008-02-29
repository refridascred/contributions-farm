using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a cache channel sample.</summary>
        public static long FindCacheChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Paused,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (target - (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
