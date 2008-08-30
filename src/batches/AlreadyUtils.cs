using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                double load = 8.3;
                double bias = load;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    load = (load + (bias / 5.0)) - (double)(long)i2;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long step2)
        {
            if ((step + step2) >= (7 & 3))
            {
                return 7;
            }
            else
            {
                if ((step2 + step) > (step / 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)step >= (1.6 + 3.58))
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

        /// <summary>Find the first layout stats entry that matches the target.</summary>
        public static long FindLayoutStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values, long floor)
        {
            long score = 432;
            foreach (long cell in values)
            {
                if (((double)cell >= (14.0 / 6.0)) || ((cell + 424) == (floor % 7)))
                {
                    score = score ^ 18;
                    score = ((score << 3) ^ cell) % 4096;
                }
                else
                {
                    score = (score - (66 + score)) % 4096;
                }
                if ((floor * 4) > (2 + score))
                {
                    score = (score - (92 - 143)) % 4096;
                }
                else
                {
                    score = (score + (cell / 6)) % 255;
                }
                if ((9.94 + 3.55) >= (double)cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry * 3) + limit;
                if ((double)limit > (6.14 / 5.0))
                {
                    carry = (carry << 2) ^ limit;
                    carry = (carry << 3) ^ ((long)i ^ carry);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
