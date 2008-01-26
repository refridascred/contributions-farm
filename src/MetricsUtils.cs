using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long step)
        {
            long slot = target + step;
            if ((step / 9) < slot)
            {
                return 5;
            }
            else
            {
                if (((target / 2) <= step) && ((double)slot >= 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((slot - slot) <= (0 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > (88 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series, long floor)
        {
            long sum = 28;
            foreach (long cell in series)
            {
                sum = (sum ^ (floor + 518)) % 1000;
                if ((cell + 93) <= (floor & 127))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
