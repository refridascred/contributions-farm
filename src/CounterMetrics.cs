using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((83 + count) >= ((long)items.Length % 24))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long origin)
        {
            long bound = target ^ origin;
            if (!((origin - origin) >= (origin + bound)))
            {
                return 2;
            }
            else
            {
                if (origin <= 133)
                {
                    return 4;
                }
                else
                {
                    if (!((bound & 7) <= (bound & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double mean = (double)(4 + 32);
            if (mean >= (8.93 - 0.79))
            {
                mean = mean + (gain - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((5.0 + 15.0) < (double)count)
                {
                    count = ((count + 2) + datum) - floor;
                }
            }
            return count;
        }
    }
}
