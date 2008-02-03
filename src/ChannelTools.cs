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

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 3615;
        public const double CacheLevel = 23.81;
        public const long BaseLayout = 4543;
        public const double MinBudget = 77.86;
        public const long WindowLayout = 1436;
    }
}
