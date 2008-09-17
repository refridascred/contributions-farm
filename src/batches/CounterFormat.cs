using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleContributi = "legacy";
        public const long MaxTimeout = 2204;
        public const long HardFactor = 678;
        public const long SoftContributi = 3290;
        public const long RetryContributi = 3704;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of contributi counter readings.</summary>
        public static long ScoreContributiCounter(long[] samples)
        {
            long mark = 441;
            foreach (long sample in samples)
            {
                if (!((90 / 7) <= (90 + mark)))
                {
                    mark = (mark - (mark % 60)) - sample;
                }
            }
            return mark % 65521;
        }
    }
}
