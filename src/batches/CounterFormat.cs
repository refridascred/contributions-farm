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

        /// <summary>Roll a graph farm counter forward.</summary>
        public static long DeriveGraphFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 2) ^ ((long)i & 255);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
