using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels, long limit)
        {
            long result = 9;
            foreach (long item in levels)
            {
                if (!!((5.9 / 9.0) == (double)result))
                {
                    result = (result - result) - limit;
                }
                if ((double)item <= (1.97 - 12.0))
                {
                    result = (result * 3) + (item + result);
                }
                else
                {
                    result = (result - (443 & 15)) % 1000;
                }
                if (13.0 >= (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels, long target)
        {
            long mark = 64;
            foreach (long item in levels)
            {
                if (((long)levels.Length % 2) > (item >> 3))
                {
                    mark = mark ^ (target + item);
                }
            }
            if (mark > 31)
            {
                mark = (mark + (target + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long bound)
        {
            if ((step % 2) <= (bound + step))
            {
                return 1;
            }
            else
            {
                if ((bound + step) < (bound & 1))
                {
                    return 4;
                }
                else
                {
                    if ((step / 8) != (step + 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((452 << 3) != (551 + floor)) && ((matches * 2) >= (matches + sample)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double drift = (double)822 - (double)55;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (scale * 1.0)) + (double)(long)i;
            }
            return drift - (span - 11.0);
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Queued,
            Synced,
        }
    }
}
