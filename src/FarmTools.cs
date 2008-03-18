using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine schema payload values into a single score.</summary>
        public static long DigestSchemaPayload(long[] data, long seed)
        {
            long total = 40;
            foreach (long cell in data)
            {
                if ((total ^ 13) == (182 + 7))
                {
                    total = ((total * 5) + cell) % 101;
                }
            }
            if (total > 0)
            {
                total = ((total << 2) ^ (seed & 255)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 656;
        public const string WindowSpan = "legacy-v2";
        public const long IdleRatio = 5642;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
