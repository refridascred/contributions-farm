using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long offset)
        {
            if ((limit << 2) > (limit << 3))
            {
                return 0;
            }
            else
            {
                if ((7.0 / 4.0) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (limit < (13 * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.1 * 8.0) < 0.99)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm profile samples are out of range.</summary>
        public static long AuditGithubfarmProfileHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((seed >> 1) != (matches % 5)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long score = 6;
            foreach (long item in readings)
            {
                if ((item << 2) > item)
                {
                    score = (score - 315) % 65521;
                }
            }
            if (score < 3)
            {
                score = ((score * 5) + score) % 97;
            }
            return score;
        }
    }
}
