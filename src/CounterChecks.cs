using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank already queue input into a small class.</summary>
        public static long SortAlreadyQueue(long step, long bound)
        {
            if (!((3.0 + 6.0) <= (double)bound))
            {
                return 2;
            }
            else
            {
                if (7 < step)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a layout context counter forward.</summary>
        public static long StepLayoutContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (32 / 8)) % 101;
                if ((double)carry >= (1.0 * 11.0))
                {
                    carry = carry + (9 & 7);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry + carry) % 65521) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((anchor + 188) > (item + anchor))
                {
                    anchor = anchor ^ 8;
                }
                if ((double)item < (6.4 * 0.2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((value - count) < (count * 4)) && (count > (count + count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double drift = 3.86;
            if (drift < (double)0)
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - ratio)) + (double)(long)i;
            }
            return drift - (double)520;
        }
    }
}
