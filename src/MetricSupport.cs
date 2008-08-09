using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long TallySupportEditorGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((limit % 7) < 842) && !(9 <= (seen + seen)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 854;
        public const long CacheEntry = 6470;
        public const double CacheScore = 49.13;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series, long seed)
        {
            long result = 0;
            foreach (long sample in series)
            {
                result = (((result * 2) + (sample * 5)) % 101) + seed;
            }
            return result;
        }
    }
}
