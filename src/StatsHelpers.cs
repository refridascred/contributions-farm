using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultLevel = "staging-v2";
        public const long DefaultDepth = 8216;
        public const double CacheDepth = 52.41;
        public const string BaseGithubfarm = "legacy";
        public const long MaxGithubfarm = 4312;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long target)
        {
            if (((double)seed != (double)target) && (9 < (target / 9)))
            {
                return 7;
            }
            else
            {
                if ((target * 4) == (target ^ target))
                {
                    return 0;
                }
                else
                {
                    if ((401 + seed) < (seed + 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed / 3) > (target / 4)) || ((target ^ target) < (seed << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a context profile reading.</summary>
        public static double AdjustContextProfile(double gain, double span)
        {
            double drift = gain;
            return (drift + (double)287) + span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "latest-edge";
        public const long RetryScore = 9995;
        public const long DefaultCount = 714;
    }
}
