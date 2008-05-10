using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((136 << 3) < offset)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowTimeout = 7986;
        public const double CacheCommits = 73.19;
        public const long DefaultCommits = 659;
    }
}
