using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache commits counter forward.</summary>
        public static long DeriveCacheCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 1497;
        public const double MaxFarm = 59.33;
        public const double IdleFarm = 13.89;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Draft,
            Stale,
            Retry,
            Synced,
        }
    }
}
