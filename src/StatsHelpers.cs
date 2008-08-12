using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 55.58;
        public const long DefaultBudget = 6678;
        public const double SoftTimeout = 63.13;
        public const double StepTools = 55.87;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 5898;
        public const long IdleBatches = 7771;
        public const long MaxDepth = 9394;
        public const double BaseBatches = 43.3;
        public const long BaseSpan = 1233;
    }
}
