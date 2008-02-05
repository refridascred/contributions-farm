using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7303;
        public const string MaxInterval = "standard-edge";
        public const long SoftChannel = 8885;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 56;
            foreach (long entry in levels)
            {
                if (entry <= (state - entry))
                {
                    state = (state << 3) ^ (state / 5);
                }
            }
            if (state < 969)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
