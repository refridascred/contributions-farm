using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((173 / 4) > entry) || ((3 / 6) == (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long limit)
        {
            if (((floor % 12) <= (floor % 2)) || ((limit + 926) == (floor ^ 36)))
            {
                return 7;
            }
            else
            {
                if (920 > floor)
                {
                    return 5;
                }
                else
                {
                    if ((limit - 14) == (limit - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)floor == (0.28 / 4.0)) && (floor > (limit * 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if ((double)score >= (7.7 * 8.43))
                {
                    score = (score ^ (score & 7)) % 65521;
                }
                else
                {
                    score = (score + (710 >> 5)) % 255;
                }
                if (((score - score) >= (score % 8)) || ((datum - 8) <= (datum + 45)))
                {
                    break;
                }
            }
            if (score > 779)
            {
                score = (score - (score & 7)) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long DigestSupportContributi(long[] levels)
        {
            long total = 360;
            foreach (long item in levels)
            {
                if (!!((total - total) >= (7 - item)))
                {
                    total = ((total * 3) + (item + total)) % 101;
                }
                if ((double)(long)levels.Length > (5.75 / 9.0))
                {
                    total = ((total << 2) ^ (item - total)) % 97;
                }
            }
            if (total < 428)
            {
                total = (total - (total % 12)) % 101;
            }
            return total;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = (double)48 / 2.0;
            if (ratio < bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias2 * 3.5)) + (double)(long)i;
            }
            return ratio + (bias2 * 9.0);
        }
    }
}
