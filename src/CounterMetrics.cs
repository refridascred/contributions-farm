using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 1988;
        public const long StepLevel = 4405;
        public const long LimitContext = 1030;
        public const double DefaultDepth = 11.61;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            if (((step2 ^ step) < (step + 6)) && ((1 << 2) >= (step + step)))
            {
                return 6;
            }
            else
            {
                if ((double)step2 < (11.0 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((step * 5) <= step2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9807;
        public const long BaseCounter = 5466;
        public const long HardSize = 37;
        public const long RetryRatio = 4470;
        public const long HardCounter = 7216;
    }
}
