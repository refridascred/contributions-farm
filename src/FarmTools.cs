using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 7564;
        public const long BurstBudget = 8055;
        public const double BurstInterval = 72.39;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Idle,
            Retry,
        }
    }
}
