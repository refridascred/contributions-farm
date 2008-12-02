using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long acc = 66;
            foreach (long cell in series)
            {
                if ((offset + acc) < (acc ^ 20))
                {
                    acc = ((acc ^ ((-6) - acc)) % 101) - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(floor > (floor ^ 4)))
                {
                    total = (total - (21 << 3)) % 4096;
                    total = ((total * 3) + (total + (long)i)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 1982;
        public const string IdleGithubfarm = "open-1";
        public const long CacheGithubfarm = 2460;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
