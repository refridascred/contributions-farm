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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
