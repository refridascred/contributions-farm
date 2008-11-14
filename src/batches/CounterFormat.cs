using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Active,
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinInterval = 2677;
        public const string WindowFactor = "stable";
        public const long BurstProfile = 6538;
        public const long BaseInterval = 41;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (3.9 + 6.25))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
