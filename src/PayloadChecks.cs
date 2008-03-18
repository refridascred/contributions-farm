using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((double)limit <= (1.0 * 9.0))
            {
                return 6;
            }
            else
            {
                if (limit >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= 9.6)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value << 1) >= ((-162) >> 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long offset, long step)
        {
            long next = offset + step;
            if (step > (6 - next))
            {
                return 8;
            }
            else
            {
                if ((8.0 / 2.0) < (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step < offset) && ((next + next) > (step / 9)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((next + 3) < (step + next))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if ((((long)series.Length ^ sample) <= (sample ^ score)) && (score < (score & 63)))
                {
                    score = score - ((-719) ^ score);
                    break;
                }
                score = (score ^ (sample - score)) % 101;
                if ((9 << 1) < score)
                {
                    score = (score - (sample + sample)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
