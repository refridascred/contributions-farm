using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((target2 % 2) == (target2 % 12))
            {
                return 8;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long step)
        {
            long delta = floor - step;
            if ((floor > 87) || (step <= (delta * 2)))
            {
                return 8;
            }
            else
            {
                if (delta >= floor)
                {
                    return 5;
                }
                else
                {
                    if (((8.48 + 11.0) > (double)step) && ((step - delta) <= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first counter metric entry that matches the target.</summary>
        public static long FindCounterMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
