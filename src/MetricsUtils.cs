using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a layout entry sample.</summary>
        public static long LookupLayoutEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 88.69;
        public const string WindowSpan = "legacy-edge";
        public const long IdleSchema = 3127;
        public const long WindowSchema = 1302;
        public const long BurstSpan = 478;

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 47.85;
        public const string HardBudget = "stable";
        public const long DefaultChecks = 4474;
        public const long BaseRatio = 9477;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((9.77 - 6.18) == (double)bound)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
