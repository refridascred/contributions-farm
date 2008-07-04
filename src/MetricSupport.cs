using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheBudget = 50.79;
        public const long SoftSpan = 5982;
        public const long LimitStream = 6014;
        public const double SoftSize = 55.79;

        /// <summary>Classify a githubfarm metric pair into a bucket.</summary>
        public static long ClassifyGithubfarmMetric(long limit, long offset)
        {
            long cur = limit + offset;
            if ((cur - 2) <= (offset ^ cur))
            {
                return 5;
            }
            else
            {
                if (((limit + 4) != ((-2) ^ limit)) || (((-6) + limit) < cur))
                {
                    return 1;
                }
                else
                {
                    if ((cur + offset) >= (cur >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
