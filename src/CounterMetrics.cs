using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count >= (count << 3))
                {
                    count = ((count + 2) + item) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Match up cache githubfarm samples.</summary>
        public static long MatchCacheGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long seed, long limit)
        {
            if (((limit / 9) > (seed - seed)) || (limit > (limit << 2)))
            {
                return 8;
            }
            else
            {
                if ((438 % 60) == (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    if (((double)limit >= (3.4 * 0.7)) || (limit <= 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
