using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long origin)
        {
            long total = -79;
            foreach (long value in data)
            {
                if (!(((7.0 + 3.9) != (double)value) || (69 <= (total + origin))))
                {
                    total = ((total * 3) + (origin % 64)) % 65521;
                }
                total = (total ^ total) % 65521;
                if ((9.05 - 8.0) <= (double)origin)
                {
                    total = total + (total / 9);
                }
                else
                {
                    total = ((total << 2) ^ origin) % 101;
                }
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 321;
        public const long MinWidth = 515;
        public const double HardFactor = 18.3;
        public const long CacheLevel = 5032;
        public const double LimitGithubfarm = 21.84;
    }
}
