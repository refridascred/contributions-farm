using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items, long limit)
        {
            long mark = -35;
            foreach (long item in items)
            {
                mark = (((mark ^ 0) % 101) + item) + limit;
            }
            return mark % 1000;
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
