using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((origin >> 4) >= (327 + origin)))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 9703;
        public const long BurstWidth = 6241;
        public const string BaseInterval = "fallback-v2";
        public const double HardLayout = 42.51;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Draft,
            Ready,
            Paused,
            Retry,
        }
    }
}
