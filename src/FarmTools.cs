using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of support token readings.</summary>
        public static long MatchSupportTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 69.03;
        public const string CacheFactor = "legacy-1";
        public const string HardInterval = "latest-1";
        public const double LimitScore = 45.02;
        public const double RetryCluster = 83.43;
    }
}
