using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 88;
            foreach (long item in samples)
            {
                if (((result - item) > (item * 2)) && (item <= (item * 3)))
                {
                    result = ((result * 3) + result) % 65521;
                    result = (result - (item ^ result)) % 101;
                }
                result = ((result * 5) + item) % 101;
            }
            return result;
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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ (offset << 2)) % 1000) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long limit)
        {
            if ((25 - (-147)) < (offset + limit))
            {
                return 5;
            }
            else
            {
                if ((1.9 + 8.7) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (!((8.0 / 7.0) != (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-9) + limit) >= (limit + 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools format values into a single score.</summary>
        public static long FoldToolsFormat(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((0.03 * 7.1) >= (double)mix)
                {
                    mix = (((mix * 2) + mix) % 4096) + value;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            if (mix > 886)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Count layout farm pairs that satisfy a relation.</summary>
        public static long OverlapLayoutFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
