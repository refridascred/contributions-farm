using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "primary-v2";
        public const long BatchGraph = 3611;
        public const long RetryGraph = 316;
        public const long WindowGraph = 9047;
        public const long WindowSize = 2805;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchLevel = "standard";
        public const long MinLevel = 919;
        public const long WindowDepth = 6675;
        public const string BaseInterval = "staging-1";
        public const long DefaultSpan = 7544;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if (((step & 255) > (step + step)) || (bound > step))
            {
                return 5;
            }
            else
            {
                if ((bound / 6) >= (step - 40))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Paused,
            Queued,
        }
    }
}
