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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                if ((-88) <= (score / 7))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
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
