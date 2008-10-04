using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstFactor = "open-1";
        public const long BaseMetrics = 2205;
        public const double BurstMetrics = 4.56;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long AuditAlreadyGithubfarmHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell ^ offset) < (cell % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
