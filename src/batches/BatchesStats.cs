using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstDepth = "latest-edge";
        public const long BurstSize = 620;
        public const long WindowBudget = 9114;
        public const double StepAccount = 11.73;
        public const long BurstBudget = 1752;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Find the first session cache entry that matches the target.</summary>
        public static long LocateSessionCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
