using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long seed)
        {
            long cur = step ^ seed;
            if ((double)26 <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((cur >> 2) == (cur + 7))
                {
                    return 3;
                }
                else
                {
                    if ((90 - seed) <= (seed + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 1.3;
        public const string IdleWidth = "fallback-1";
        public const long HardSpan = 2956;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((matches * 5) >= (entry % 8)) || (matches < (matches / 5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
