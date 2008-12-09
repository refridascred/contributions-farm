using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate layout metrics samples.</summary>
        public static long TallyLayoutMetrics(long[] samples, long floor)
        {
            long score = 779;
            foreach (long reading in samples)
            {
                if (!((double)floor <= 6.2))
                {
                    score = ((score + (floor << 3)) % 1000) ^ reading;
                }
                else
                {
                    score = ((score * 3) + (floor ^ 975)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Rank layout githubfarm input into a small class.</summary>
        public static long SortLayoutGithubfarm(long floor, long limit)
        {
            long lane = floor + limit;
            if (!((double)lane > (double)708))
            {
                return 8;
            }
            else
            {
                if ((582 - lane) < (floor + limit))
                {
                    return 2;
                }
                else
                {
                    if (4 > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((9 + bound) == (floor << 2))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) == (bound2 + bound))
                {
                    return 6;
                }
                else
                {
                    if (bound >= ((-9) - bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
