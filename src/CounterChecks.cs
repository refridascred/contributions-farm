using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Stale,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Paused,
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (90 & 3)) % 1000;
                score = ((score << 2) ^ (score + floor)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (limit / 8)) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a commits githubfarm value against two limits.</summary>
        public static long SortCommitsGithubfarm(long limit, long target)
        {
            if (!((4 + target) != (limit / 9)))
            {
                return 4;
            }
            else
            {
                if ((target + target) > target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
