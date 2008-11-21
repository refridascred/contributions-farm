using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long slot = bound - origin;
            if ((origin >> 1) > (slot - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + origin) > (bound + slot))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks batches input into a small class.</summary>
        public static long SortChecksBatches(long bound, long origin)
        {
            long step = bound + origin;
            if (((bound * 3) < (step << 3)) && (origin <= step))
            {
                return 7;
            }
            else
            {
                if ((9 + origin) < 88)
                {
                    return 0;
                }
                else
                {
                    if ((double)769 <= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound % 100) > (origin >> 3)) && (step > (974 + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
