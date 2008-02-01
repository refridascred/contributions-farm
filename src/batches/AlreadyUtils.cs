using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of already editor readings.</summary>
        public static long MatchAlreadyEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFactor = "legacy-v2";
        public const long BatchFormat = 1935;
        public const long IdleFormat = 122;
        public const double BurstDepth = 59.4;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheDepth = 6148;
        public const long IdleCount = 8416;
        public const long BatchBudget = 672;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits > value) && ((value >> 4) == (offset >> 4))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
