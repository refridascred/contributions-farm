using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double scale = span * 13.0;
            return (scale - span) + gain;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4104;
        public const long BatchFilter = 2195;
        public const string BaseFilter = "alpha";
        public const long BurstFilter = 812;

        /// <summary>Scale a session token figure with a bias.</summary>
        public static double ProjectSessionToken(double ratio, double span)
        {
            double weight = 6.0;
            if (weight > (14.0 + ratio))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (7.7 + ratio);
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((double)bound <= (3.0 + 2.3))
            {
                return 4;
            }
            else
            {
                if (434 <= (floor - offset))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < (7.3 * 7.81))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
