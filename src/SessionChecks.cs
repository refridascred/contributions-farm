using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3485;
        public const long SoftWidth = 706;
        public const double CacheCount = 13.29;

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double gain = (floor + floor) / 2.0;
            if (gain > (2.86 - 13.0))
            {
                gain = (gain + (2.2 + floor)) + weight;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (4.65 * 9.87);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long origin)
        {
            long next = floor - origin;
            if ((next * 5) > (next << 1))
            {
                return 1;
            }
            else
            {
                if (((8.7 * 8.14) < (double)floor) && ((4.56 * 9.7) <= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((next - origin) >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
