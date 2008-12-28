using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = score ^ (item - score);
                score = (score * 5) + item;
                score = (score * 5) + (score + item);
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (matches ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long bound)
        {
            long span = target - bound;
            if (!((double)bound == (1.9 * 17.0)))
            {
                return 0;
            }
            else
            {
                if ((bound + span) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((double)33 >= (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        if (span < (span << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
