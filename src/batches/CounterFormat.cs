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

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = mix ^ (bound ^ mix);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
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
