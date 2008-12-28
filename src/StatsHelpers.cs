using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next already filter value from a seed.</summary>
        public static long StepAlreadyFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor << 2) ^ 8) % 101;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinTimeout = 8884;
        public const long BurstChannel = 3683;
        public const string MinSpan = "stable-edge";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((double)bound > (1.63 + 16.0))
            {
                return 2;
            }
            else
            {
                if ((8 << 3) == (bound ^ prev))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double bias = (double)(0 + (-87));
            return ((bias - (double)245) + gain) + offset;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
