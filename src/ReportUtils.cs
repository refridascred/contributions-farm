using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double ratio, double floor)
        {
            double load = ratio - (floor * 2.0);
            if (load < floor)
            {
                load = load - (double)98;
            }
            else
            {
                load = load + (load / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)(-4)) - (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long carry = 30;
            foreach (long reading in samples)
            {
                if ((reading * 3) != (carry - carry))
                {
                    carry = (carry + (reading ^ reading)) % 255;
                }
                else
                {
                    carry = carry ^ (reading >> 1);
                }
                if (!((1.78 + 7.3) > (double)reading))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] samples)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                if ((3 - 0) >= (cell << 2))
                {
                    result = result + (cell & 7);
                    result = result + (cell % 64);
                }
                if ((31 << 2) <= cell)
                {
                    result = ((result * 3) + cell) % 4096;
                }
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
