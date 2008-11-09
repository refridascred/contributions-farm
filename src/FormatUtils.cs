using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long AuditContributiContextHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((46 + 382) < ((long)items.Length + item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long floor)
        {
            if (((floor << 3) > seed) || ((6 + floor) > (970 << 1)))
            {
                return 7;
            }
            else
            {
                if (!((seed ^ floor) == (22 & 3)))
                {
                    return 0;
                }
                else
                {
                    if (((684 % 97) <= (floor + seed)) || ((seed % 3) != (floor - 93)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed == (6.0 * 0.26))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitCount = 85.44;
        public const long MaxProfile = 6602;
        public const double MaxSpan = 62.07;

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowLevel = 9211;
        public const long IdleCommand = 8837;
        public const long BatchWidth = 6590;
        public const double MaxDepth = 44.28;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "cached-1";
        public const long BaseBudget = 1753;
        public const long BatchCommits = 2841;

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 18.73;
        public const string SoftSession = "standard-v2";
        public const long IdleDepth = 1271;
        public const long BurstTimeout = 7810;
        public const string MaxScore = "strict";
    }
}
