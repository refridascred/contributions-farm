using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "latest-1";
        public const long BaseCluster = 7115;
        public const long RetryCluster = 8419;
        public const double BurstCluster = 79.18;
        public const string DefaultTimeout = "fallback-v2";
    }
}
