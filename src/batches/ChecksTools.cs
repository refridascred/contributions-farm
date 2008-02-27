using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheSize = 6817;
        public const string IdleCount = "latest-edge";
        public const string BurstGraph = "legacy-1";
        public const long DefaultBudget = 3501;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long seed, long target)
        {
            long cur = seed ^ target;
            if (!((seed ^ cur) >= (seed % 60)))
            {
                return 4;
            }
            else
            {
                if ((5.8 < (double)cur) || ((double)seed >= (6.51 / 4.0)))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) < (cur - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double weight = 17.0;
            if (weight > gain)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + (gain - weight);
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double bias = (double)(66 - 96);
            if (bias > (scale + floor))
            {
                bias = bias + scale;
            }
            return bias + bias;
        }
    }
}
