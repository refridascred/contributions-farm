using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "local";
        public const double LimitTimeout = 31.51;
        public const double DefaultRatio = 13.17;
        public const long LimitMetric = 3281;
        public const double SoftLevel = 11.55;

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long floor)
        {
            long slot = seed - floor;
            if (((double)slot >= 9.36) && ((-285) > (slot ^ floor)))
            {
                return 8;
            }
            else
            {
                if ((floor - seed) == (slot + seed))
                {
                    return 5;
                }
                else
                {
                    if ((floor - 326) > (seed >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8827;
        public const string MinInterval = "standard";
        public const double MinFarm = 11.19;
    }
}
