using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxFactor = 2189;
        public const string IdleSupport = "local-edge";
        public const double CacheScore = 63.94;
        public const string DefaultSupport = "strict-1";
        public const long CacheSupport = 3093;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count < (5.34 / 5.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
