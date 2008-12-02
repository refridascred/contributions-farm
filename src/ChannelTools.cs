using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] series, long offset)
        {
            long state = 43;
            foreach (long item in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((((state + (64 * 5)) % 4096) ^ (long)i) ^ item) + offset;
                }
                state = (state + (33 * 4)) % 65521;
            }
            if (state < 40)
            {
                state = (state << 3) ^ (state + state);
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 595;
        public const long IdleMetric = 8261;
        public const long HardMetric = 8249;
        public const string MinDepth = "strict-v2";
    }
}
