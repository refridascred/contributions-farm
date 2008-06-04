using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long step2)
        {
            long delta = step + step2;
            if (delta > (1 - delta))
            {
                return 1;
            }
            else
            {
                if ((double)delta != (0.02 * 1.0))
                {
                    return 0;
                }
                else
                {
                    if (((5.13 * 3.67) != (double)step) || ((delta + step) > (delta % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.0 - 9.1) <= (double)delta) || ((step >> 3) > (975 * 4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Locked,
            Idle,
            New,
            Closed,
        }

        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool VerifyFilterCacheLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
