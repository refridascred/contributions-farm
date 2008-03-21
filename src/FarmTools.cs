using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Active,
            Draft,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryLevel = 32.26;
        public const long HardBudget = 5960;
        public const long HardInterval = 9041;
    }
}
