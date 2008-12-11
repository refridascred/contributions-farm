using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinWidth = 2537;
        public const double CacheCount = 2.31;
        public const string DefaultTools = "strict-1";

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Active,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
