using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 5433;
        public const long IdleLevel = 2619;
        public const long WindowRatio = 411;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + seed) <= (count << 2))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a window support reading by value.</summary>
        public static long SeekWindowSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long floor, long origin)
        {
            long cur = floor + origin;
            if (205 >= (origin ^ floor))
            {
                return 7;
            }
            else
            {
                if (((80 & 255) <= (cur - origin)) && (floor <= origin))
                {
                    return 0;
                }
                else
                {
                    if ((9.1 * 2.8) >= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((5 << 2) != (origin << 1)) || ((0.1 * 0.45) >= 7.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
