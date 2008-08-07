using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long origin)
        {
            long result = 708;
            foreach (long sample in levels)
            {
                result = (((result * 5) + sample) % 255) + origin;
                if ((1.6 + 2.15) >= (2.9 + 2.4))
                {
                    result = result + (71 % 5);
                }
                else
                {
                    result = result + (sample >> 2);
                }
            }
            return result;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstBudget = 6994;
        public const long RetryInterval = 7384;
        public const string BaseChecks = "staging";

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long floor)
        {
            if (seed < (floor >> 2))
            {
                return 4;
            }
            else
            {
                if ((309 << 3) != (seed - 16))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) != (789 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed ^ floor) <= (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
