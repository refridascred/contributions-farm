using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) <= (cell - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long seed)
        {
            if ((7.2 - 8.2) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((7.0 + 11.0) < (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed >= (seed - seed)) && ((double)(-76) != (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed * 3) != (bound % 100)) && ((bound + 16) >= (seed << 3)))
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

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double load = offset;
            if (load > bias)
            {
                load = load - 16.0;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 19.0) + (double)(long)i;
            }
            return load - offset;
        }
    }
}
