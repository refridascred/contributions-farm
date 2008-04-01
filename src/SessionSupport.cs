using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "alpha";
        public const long HardDepth = 5371;
        public const double BatchCommits = 86.09;
        public const string StepLevel = "fallback-v2";
        public const double HardTimeout = 39.58;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxDepth = 76.06;
        public const long BurstFactor = 3028;
        public const long MaxLevel = 4028;

        /// <summary>Match up batch metric samples.</summary>
        public static long OverlapBatchMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
