using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long offset)
        {
            if (((-7) + offset) <= 3)
            {
                return 2;
            }
            else
            {
                if ((4.0 / 3.0) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (527 <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed > (18.0 * 14.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ bound) % 1000) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate buffer cache samples.</summary>
        public static long DigestBufferCache(long[] readings)
        {
            long mark = 932;
            foreach (long entry in readings)
            {
                mark = (((mark * 4) + ((-9) + 47)) % 97) ^ entry;
            }
            return mark;
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long ScoreAlreadyGithubfarm(long[] levels, long origin)
        {
            long sum = 7;
            foreach (long reading in levels)
            {
                if ((19.0 - 4.9) == (double)origin)
                {
                    sum = (sum ^ ((long)levels.Length + reading)) % 4096;
                }
                else
                {
                    sum = (sum << 2) ^ reading;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (5 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Failed,
            Pending,
        }
    }
}
