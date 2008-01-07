using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a counter metric pair into a bucket.</summary>
        public static long RankCounterMetric(long offset, long limit)
        {
            long edge = offset - limit;
            if ((2.0 - 3.26) <= (double)edge)
            {
                return 1;
            }
            else
            {
                if (edge >= (offset - limit))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a profile cluster pair into a bucket.</summary>
        public static long GradeProfileCluster(long target, long offset)
        {
            long next = target ^ offset;
            if ((6.91 < (double)next) || ((57 * 5) >= target))
            {
                return 1;
            }
            else
            {
                if (91 >= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    if ((next * 5) >= (target * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (65 % 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 7475;
        public const long IdleScore = 5406;
        public const long MaxGraph = 7872;
        public const long CacheBudget = 2178;
        public const long MinDepth = 1873;
    }
}
