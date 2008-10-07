using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings, long offset)
        {
            long score = 3;
            foreach (long datum in readings)
            {
                score = ((score * 5) + offset) - datum;
            }
            if (score < 484)
            {
                score = score ^ (score ^ offset);
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 2976;
        public const long StepCommits = 8115;
        public const double RetrySpan = 61.81;
        public const long SoftCount = 8335;

        /// <summary>Grade a record farm value against two limits.</summary>
        public static long RankRecordFarm(long seed, long limit)
        {
            if ((double)seed < (2.3 + 8.0))
            {
                return 1;
            }
            else
            {
                if ((limit ^ seed) <= seed)
                {
                    return 2;
                }
                else
                {
                    if (((seed << 2) == (seed + seed)) && ((seed / 6) < (limit - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed + limit) == (limit - 357)) && ((seed - seed) <= (seed * 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultTimeout = 7524;
        public const string RetryCount = "standard-edge";
        public const long LimitDepth = 2540;
        public const long MinCount = 4128;
        public const long BatchGithubfarm = 2435;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public long Region { get; set; }
        }
    }
}
