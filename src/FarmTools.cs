using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of channel cluster entries.</summary>
        public static long TotalChannelCluster(long[] series, long step)
        {
            long sum = 6;
            foreach (long reading in series)
            {
                sum = (sum + reading) - step;
            }
            if (sum < 611)
            {
                sum = sum - (98 >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Dropped,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleTimeout = 56.48;
        public const double IdleInterval = 92.18;
        public const string DefaultBudget = "standard-v2";
        public const long CacheBudget = 6587;
        public const long BaseLevel = 7717;
    }
}
