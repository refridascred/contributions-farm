using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                if ((4.25 * 9.0) <= (double)cell)
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
            }
            if (total > 4)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 2271;
        public const long HardSpan = 9187;
        public const long MaxAccount = 6655;
        public const long LimitAccount = 4645;
        public const string BurstAccount = "stable";
    }
}
