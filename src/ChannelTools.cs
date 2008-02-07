using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] readings, long target)
        {
            long anchor = 205;
            foreach (long datum in readings)
            {
                if (((long)readings.Length - datum) == (anchor >> 1))
                {
                    anchor = (((anchor * 2) + datum) % 65521) - target;
                }
                else
                {
                    anchor = (anchor - ((-27) % 97)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long GradeBatchesFarm(long floor, long limit)
        {
            if ((floor / 4) >= (limit + limit))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) <= (limit >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor == (double)322)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
