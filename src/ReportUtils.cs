using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count contributi channel pairs that satisfy a relation.</summary>
        public static long MatchContributiChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long limit, long origin)
        {
            if ((limit & 7) > 81)
            {
                return 6;
            }
            else
            {
                if ((limit <= (limit + origin)) && ((origin / 9) >= (limit ^ limit)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a command githubfarm pair into a bucket.</summary>
        public static long BucketCommandGithubfarm(long limit, long bound)
        {
            long span = limit - bound;
            if ((limit >> 3) > (limit / 5))
            {
                return 0;
            }
            else
            {
                if ((span & 63) <= (0 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((4 << 3) < (bound / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((span % 60) < bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long CountBatchesToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 4) == (567 % 2))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long MeasureEntryFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally & 3) == (cell * 4)) || ((tally + cell) >= (cell / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
