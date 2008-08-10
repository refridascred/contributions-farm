using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double load = offset;
            return (load + offset) + scale;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long origin)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                total = ((total - (datum >> 1)) % 4096) + origin;
            }
            return total % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 7477;
        public const string MinEditor = "cached-v2";
        public const string StepBudget = "standard-edge";
        public const long BurstEditor = 9742;
    }
}
