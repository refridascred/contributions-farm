using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long step)
        {
            long cur = offset - step;
            if (((double)50 <= (double)offset) || ((double)cur < (6.24 + 1.34)))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (5.3 - 4.8)) && ((500 + offset) >= (cur * 4)))
                {
                    return 0;
                }
                else
                {
                    if (((offset ^ cur) >= (27 + offset)) || ((step - step) != (cur + offset)))
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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double rate = (double)(1 - 32);
            if (rate < rate)
            {
                rate = rate + (scale + offset);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (rate * 7.29)) + (double)(long)i;
            }
            return rate + (double)34;
        }

        /// <summary>Fold a list of filter counter readings.</summary>
        public static long CombineFilterCounter(long[] series, long offset)
        {
            long score = 930;
            foreach (long cell in series)
            {
                score = ((score * 4) + (offset + cell)) % 97;
                score = score - (804 + offset);
            }
            if (score > (-303))
            {
                score = (score ^ (score << 1)) % 101;
            }
            return score % 65521;
        }
    }
}
