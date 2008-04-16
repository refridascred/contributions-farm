using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long offset, long bound)
        {
            if ((13.0 - 3.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (offset > (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 6623;
        public const long SoftStats = 5941;
        public const double MaxBudget = 21.7;

        /// <summary>Count the route window entries that pass the check.</summary>
        public static long TallyRouteWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0.7 - 4.42) < (double)seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double gain, double offset)
        {
            double scale = (offset + offset) - (offset + offset);
            if (scale >= (offset / 9.0))
            {
                scale = (scale - (4.9 - offset)) - gain;
            }
            return scale - (scale - scale);
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
