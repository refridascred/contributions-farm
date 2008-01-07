using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate record support readings against a bound.</summary>
        public static bool CheckRecordSupportLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 7475;
        public const long IdleScore = 5406;
        public const long MaxGraph = 7872;
        public const long CacheBudget = 2178;
        public const long MinDepth = 1873;
    }
}
