using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every checks githubfarm entry stays within the limit.</summary>
        public static bool VerifyChecksGithubfarmRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long FoldGraphReport(long[] readings, long step)
        {
            long score = 323;
            foreach (long datum in readings)
            {
                score = (score - score) + step;
                if ((double)datum != (7.5 - 5.65))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long limit, long bound)
        {
            long edge = limit ^ bound;
            if (((limit / 8) > (60 - edge)) && ((9.51 / 8.0) != (double)edge))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (2.99 - 16.0))
                {
                    return 2;
                }
                else
                {
                    if (edge > limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long origin, long limit)
        {
            if ((0 << 3) >= (limit - limit))
            {
                return 5;
            }
            else
            {
                if ((18 <= (origin >> 1)) || ((limit + 4) >= (560 % 3)))
                {
                    return 6;
                }
                else
                {
                    if (!((limit + limit) == (origin + (-97))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + limit) < (origin * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
