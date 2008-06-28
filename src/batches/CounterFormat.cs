using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "alpha-v2";
        public const long HardTools = 273;
        public const long HardBudget = 6350;
        public const long BurstTools = 2597;

        /// <summary>Fold a list of channel command readings.</summary>
        public static long FoldChannelCommand(long[] readings)
        {
            long state = 94;
            foreach (long cell in readings)
            {
                state = state + cell;
            }
            if (state < 240)
            {
                state = (state << 2) ^ (state % 100);
            }
            return state % 1000;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            New,
            Paused,
            Done,
        }
    }
}
