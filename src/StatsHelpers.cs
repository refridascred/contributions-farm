using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double scale = (double)374 - (ratio * 11.0);
            if (scale >= ratio)
            {
                scale = scale + (ratio * 1.8);
            }
            else
            {
                scale = scale - (double)20;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Classify a route graph pair into a bucket.</summary>
        public static long BucketRouteGraph(long origin, long target)
        {
            if ((19.0 + 15.0) >= (5.0 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) >= (origin << 1))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double bias = offset * 0.46;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + bias) + (double)(long)i) - gain;
            }
            return bias - (offset * 1.9);
        }
    }
}
