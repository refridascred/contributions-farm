using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if ((double)floor != (8.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if (!((floor * 4) > 33))
                {
                    return 6;
                }
                else
                {
                    if (98 < (bound + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a graph profile figure with a bias.</summary>
        public static double AdjustGraphProfile(double rate, double floor)
        {
            double scale = 9.5;
            if (scale > scale)
            {
                scale = (scale + (scale + 11.0)) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor / 8.0)) - (double)(long)i;
            }
            return scale + (scale + floor);
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
