using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next farm record value.</summary>
        public static double ScaleFarmRecord(double weight, double bias)
        {
            double gain = (bias - bias) + (weight - weight);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double offset)
        {
            double drift = offset - scale;
            return drift - (double)390;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                if (offset >= (offset - carry))
                {
                    carry = (carry - offset) % 255;
                }
                carry = (carry ^ offset) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Match up token session samples.</summary>
        public static long CompareTokenSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long target)
        {
            if ((target + 8) < target)
            {
                return 4;
            }
            else
            {
                if ((bound / 2) >= (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
