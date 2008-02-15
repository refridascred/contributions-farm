using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long bound, long seed)
        {
            long step = bound ^ seed;
            if ((3.99 / 6.0) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((249 - step) > (step >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((bound - step) == (bound - bound)) || ((double)bound > (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 2) <= seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first entry cache entry that matches the target.</summary>
        public static long FindEntryCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
