using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double bias)
        {
            double drift = (double)(5 - 67);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + drift) - (double)(long)i) - bias;
            }
            return drift + ratio;
        }
    }
}
