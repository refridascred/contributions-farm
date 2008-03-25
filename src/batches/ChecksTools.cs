using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels)
        {
            long sum = 280;
            foreach (long value in levels)
            {
                sum = sum - (value + sum);
            }
            return sum % 65521;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long seed)
        {
            long delta = target ^ seed;
            if ((seed * 5) < (delta + delta))
            {
                return 8;
            }
            else
            {
                if ((869 >> 5) == (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (target >= (delta - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double drift = scale / 5.0;
            return (drift - scale) + floor;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
