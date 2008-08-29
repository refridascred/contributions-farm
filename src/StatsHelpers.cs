using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            New,
            Stale,
        }

        /// <summary>Rank payload profile input into a small class.</summary>
        public static long SortPayloadProfile(long seed, long bound)
        {
            if (((bound % 7) >= (bound & 31)) || ((seed - seed) == (seed % 16)))
            {
                return 7;
            }
            else
            {
                if ((2 << 1) != (bound & 127))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 3) > (seed / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next order session value from a seed.</summary>
        public static long StepOrderSession(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if ((1.0 + 9.39) != (double)step)
                {
                    score = (score * 2) + ((long)i << 2);
                }
                else
                {
                    score = ((score << 3) ^ (score * 2)) % 1000;
                }
                if (((score - score) > (score << 1)) || ((long)i >= ((long)i + step)))
                {
                    score = ((score << 2) ^ (step + (long)i)) % 101;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSpan = 1734;
        public const long BatchRatio = 6768;
        public const long StepScore = 6229;
        public const long BurstRatio = 6296;
        public const long HardCount = 1026;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((item & 1) <= step) || ((double)7 > (double)step))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
