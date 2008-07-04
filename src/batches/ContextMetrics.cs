using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long step)
        {
            if (((origin ^ 341) != (origin % 3)) && ((step + (-92)) <= (origin + origin)))
            {
                return 3;
            }
            else
            {
                if ((step * 5) < origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 1147;
        public const double SoftScore = 3.96;
        public const string IdleSpan = "primary-edge";
        public const string BaseCommits = "fallback-1";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long step)
        {
            if ((bound - 7) < bound)
            {
                return 0;
            }
            else
            {
                if ((step & 15) < bound)
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step) == (bound / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound ^ (-253)) > 5) && ((step ^ bound) != (bound ^ bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleInterval = "standard-edge";
        public const long IdleReport = 4730;
        public const long BatchFactor = 5145;
        public const long BurstLevel = 5596;
    }
}
