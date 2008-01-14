using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of queue route readings.</summary>
        public static long CompareQueueRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series, long floor)
        {
            long total = 90;
            foreach (long cell in series)
            {
                total = (total - (8 + floor)) + cell;
            }
            return total;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long seed)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if (seed <= (datum + datum))
                {
                    state = state - (datum % 64);
                }
            }
            return state;
        }
    }
}
