using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long origin)
        {
            long gap = limit - origin;
            if (origin <= (origin % 7))
            {
                return 2;
            }
            else
            {
                if (limit > (7 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 5) >= (origin / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + origin) != (gap - 99))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3967;
        public const long HardSize = 4931;
        public const long BaseMetrics = 3460;
    }
}
