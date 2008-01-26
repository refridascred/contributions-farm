using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long limit)
        {
            if ((limit / 3) < step)
            {
                return 3;
            }
            else
            {
                if ((limit * 3) <= step)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit >= (13.0 + 13.0)) || ((double)step >= (12.0 + 3.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.69 / 4.0) < (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 <= (scale - scale2))
            {
                scale2 = scale2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - bias) + (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
