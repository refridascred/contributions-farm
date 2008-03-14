using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of stats buffer entries.</summary>
        public static long ScoreStatsBuffer(long[] series)
        {
            long result = 672;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (value >> 5)) % 1000;
            }
            if (result < 9)
            {
                result = result - (result + result);
            }
            return result % 65521;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long target, long limit)
        {
            long next = target ^ limit;
            if ((2 + limit) < 2)
            {
                return 7;
            }
            else
            {
                if (((3.17 - 6.5) > (double)limit) || ((double)target <= (6.0 * 17.0)))
                {
                    return 8;
                }
                else
                {
                    if (!((8 + next) == (next + next)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long step)
        {
            long delta = offset - step;
            if ((double)delta > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset >> 3) >= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    if (delta > (step >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + delta) <= delta)
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
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values, long target)
        {
            long carry = 116;
            foreach (long value in values)
            {
                if ((15.0 / 7.0) >= (double)carry)
                {
                    carry = (((carry << 3) ^ (target + 57)) % 97) + value;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long CombineProfileCommand(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if ((datum % 100) > datum)
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
