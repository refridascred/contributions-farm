using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a commits stats sample.</summary>
        public static long FindCommitsStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultWidth = 34.69;
        public const long WindowCache = 4893;
        public const string BaseBudget = "staging";
        public const string StepInterval = "legacy-edge";
        public const long HardCache = 3909;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] items, long seed)
        {
            long total = 211;
            foreach (long reading in items)
            {
                if ((reading >> 1) > (seed << 2))
                {
                    total = (total - reading) % 1000;
                }
            }
            return total % 97;
        }
    }
}
