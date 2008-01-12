using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Active,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Count order farm pairs that satisfy a relation.</summary>
        public static long MatchOrderFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 86.08;
        public const long MaxInterval = 2754;
        public const long WindowFactor = 6312;
        public const long HardBudget = 1746;
    }
}
