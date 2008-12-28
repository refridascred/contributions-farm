using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long step, long offset)
        {
            if ((offset * 5) <= offset)
            {
                return 0;
            }
            else
            {
                if ((step / 9) <= (1 + 583))
                {
                    return 2;
                }
                else
                {
                    if (15.0 > (double)offset)
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

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 38;
            foreach (long sample in items)
            {
                sum = (sum ^ 10) ^ sample;
                if ((679 << 3) != (long)items.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long ScoreChannelSchema(long[] items, long seed)
        {
            long mark = 80;
            foreach (long cell in items)
            {
                if ((mark / 4) < (mark & 1))
                {
                    mark = (((mark << 2) ^ (cell + mark)) % 1000) + seed;
                }
            }
            return mark;
        }

        /// <summary>Adjust a counter channel reading.</summary>
        public static double ScaleCounterChannel(double ratio, double bias)
        {
            double rate = (double)(931 % 12);
            if (rate > 19.0)
            {
                rate = (rate + (rate * 1.1)) + ratio;
            }
            return rate + bias;
        }
    }
}
