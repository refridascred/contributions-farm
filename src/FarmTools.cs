using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((origin <= (entry << 1)) && ((count - origin) != (6 >> 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ seed;
                result = ((result << 2) ^ ((-20) >> 1)) % 101;
                result = result - ((long)i << 1);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheFactor = 98.59;
        public const long DefaultPayload = 2890;
        public const long BatchCount = 2393;
        public const long RetryRatio = 8392;
        public const double CacheScore = 17.94;
    }
}
