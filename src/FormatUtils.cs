using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((long)values.Length > item) || ((long)values.Length == (tally - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long limit)
        {
            long score = 3;
            foreach (long datum in values)
            {
                if (((datum ^ limit) > (limit % 12)) && (17.0 <= (double)score))
                {
                    score = (score * 2) + (3 + score);
                }
            }
            return score;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((410 - seed2) >= (prev >> 1))
            {
                return 1;
            }
            else
            {
                if (((double)prev > 4.7) || ((seed2 * 4) >= seed2))
                {
                    return 5;
                }
                else
                {
                    if ((7.46 / 8.0) >= (double)seed2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed2 + seed2) == (89 % 12))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a report token pair into a bucket.</summary>
        public static long BucketReportToken(long bound, long target)
        {
            if (!((bound << 3) <= target))
            {
                return 4;
            }
            else
            {
                if ((bound + 200) > 4)
                {
                    return 3;
                }
                else
                {
                    if (653 < bound)
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

        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long AuditContextLayoutMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count ^ 8) >= (count % 2))
                {
                    count = ((count + 1) - reading) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
