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

        /// <summary>Validate farm metrics readings against a bound.</summary>
        public static bool CheckFarmMetricsRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
