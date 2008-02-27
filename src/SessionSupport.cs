using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowInterval = 8792;
        public const double SoftChannel = 34.31;
        public const double CacheLevel = 67.87;
        public const double BaseChannel = 16.67;
        public const long MinChannel = 9042;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= (7.3 * 4.39))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
