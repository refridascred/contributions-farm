using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long bound)
        {
            if (limit <= (limit & 15))
            {
                return 4;
            }
            else
            {
                if ((0.39 < (double)bound) || (18.0 <= (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) >= (limit + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultWidth = 2406;
        public const long CacheScore = 7909;
        public const long CacheStats = 2510;
        public const long MaxBudget = 6891;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleDepth = 9885;
        public const long MaxInterval = 7814;
        public const double StepChannel = 6.43;
    }
}
