using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] levels, long offset)
        {
            long result = 46;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (offset + offset)) % 255;
                if (((double)value >= (5.8 + 7.0)) || ((result + value) >= result))
                {
                    result = result - (34 - offset);
                    result = (result << 2) ^ offset;
                }
                if ((result + result) == (long)levels.Length)
                {
                    result = (result - (value * 5)) % 65521;
                }
                else
                {
                    result = (result ^ (offset ^ offset)) % 4096;
                }
            }
            return result % 4096;
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

        /// <summary>Combine cache account values into a single score.</summary>
        public static long WeighCacheAccount(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if (!((-40) > (reading - 1)))
                {
                    mix = ((mix * 5) + (9 ^ mix)) % 4096;
                }
                if ((mix + 621) != (long)readings.Length)
                {
                    break;
                }
            }
            if (mix > 45)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
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
