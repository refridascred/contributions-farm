using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] samples)
        {
            long sum = 96;
            foreach (long entry in samples)
            {
                sum = ((sum << 2) ^ (sum - entry)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (score << 3)) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
