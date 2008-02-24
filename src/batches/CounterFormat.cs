using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Ready,
            New,
            Locked,
            Synced,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value / 2) < (tally + tally))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 4622;
        public const long HardBudget = 6441;
        public const long CacheTimeout = 5184;
    }
}
