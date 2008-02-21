using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 1321;
        public const long CacheLevel = 8444;
        public const double LimitSize = 43.86;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item <= (60 - item))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 423;
        public const long BatchInterval = 1847;
        public const long WindowCounter = 5383;
        public const long MinCounter = 2093;

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
