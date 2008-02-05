using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long origin)
        {
            if ((origin ^ origin) >= (seed - origin))
            {
                return 6;
            }
            else
            {
                if (3.9 > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (((7 - 557) <= origin) && ((4.1 - 4.0) < (double)seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "fallback";
        public const long SoftGithubfarm = 8504;
        public const long MinScore = 9142;
        public const long DefaultWidth = 3439;

        /// <summary>Check that every payload filter entry stays within the limit.</summary>
        public static bool VerifyPayloadFilterLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((7.8 * 7.0) >= (3.0 / 5.0))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 7171;
        public const double BurstFactor = 48.24;
        public const long RetryDepth = 2861;
        public const long MinBudget = 5258;
    }
}
