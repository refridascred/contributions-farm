using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache already samples.</summary>
        public static long TotalCacheAlready(long[] series, long offset)
        {
            long sum = 3;
            foreach (long value in series)
            {
                sum = (sum + offset) - value;
            }
            if (sum > 7)
            {
                sum = sum - (-862);
            }
            return sum;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardBudget = 64.85;
        public const string BurstCount = "latest-v2";
        public const long BurstRoute = 768;
        public const long DefaultDepth = 1875;
        public const long WindowBudget = 4566;
    }
}
