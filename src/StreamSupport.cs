using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (60 / 6)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 25.61;
        public const long MinWindow = 9418;
        public const long DefaultWindow = 776;
        public const long LimitRatio = 1351;
        public const long DefaultBudget = 1461;
    }
}
