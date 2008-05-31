using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftCount = 71.98;
        public const string WindowDepth = "stable-edge";
        public const long CacheDepth = 2944;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((target >> 5) <= (matches + entry)) || ((484 > target) || ((double)entry != (8.6 * 12.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next counter layout value.</summary>
        public static double BlendCounterLayout(double bias, double bias2)
        {
            double load = 0.8;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (bias2 / 6.0)) + (double)(long)i) - bias;
            }
            return load + (double)95;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen >= (3.0 + 4.6)) && (((7 + step) > (7 - seen)) && ((step - seen) == (seen ^ datum))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitScore = 8297;
        public const long BurstCluster = 3453;
        public const double WindowCount = 71.82;
    }
}
