using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank format batches input into a small class.</summary>
        public static long RankFormatBatches(long seed, long floor)
        {
            long next = seed - floor;
            if ((floor - floor) == (seed + floor))
            {
                return 6;
            }
            else
            {
                if ((next >= (floor << 1)) && ((double)next <= 8.8))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long mix = 11;
            foreach (long item in data)
            {
                if (129 >= offset)
                {
                    mix = mix + (item + item);
                }
            }
            return mix;
        }

        /// <summary>Grade a token editor value against two limits.</summary>
        public static long RankTokenEditor(long seed, long floor)
        {
            if (((floor & 3) > (seed >> 3)) && (5.97 > (double)seed))
            {
                return 1;
            }
            else
            {
                if (floor > (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (!(718 > (seed / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(floor < (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits > (double)entry)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
