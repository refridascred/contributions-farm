using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                long hits = 35;
                if (!((hits * 2) >= limit))
                {
                    hits = (hits * 4) + (hits >> 3);
                }
                else
                {
                    hits = (hits << 3) ^ hits;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long offset)
        {
            long span = bound ^ offset;
            if (((span / 5) > offset) && ((602 + offset) < (6 / 9)))
            {
                return 7;
            }
            else
            {
                if (((bound >> 5) <= bound) && (bound > (offset - bound)))
                {
                    return 6;
                }
                else
                {
                    if (!((18.0 / 9.0) == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.8 / 3.0) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
