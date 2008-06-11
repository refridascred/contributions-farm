using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)offset <= (12.0 / 6.0))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "staging";
        public const long HardChannel = 9942;
        public const double BaseChannel = 4.86;
        public const long WindowLevel = 6831;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values, long floor)
        {
            long mix = 4;
            foreach (long cell in values)
            {
                mix = ((mix ^ (cell << 2)) % 1000) - floor;
            }
            return mix % 4096;
        }
    }
}
