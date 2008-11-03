using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long carry = 85;
            foreach (long item in levels)
            {
                if ((item + item) >= (item % 7))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
                if ((double)carry >= (2.16 * 5.6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double gain = (double)(672 % 100);
            for (int i = 0; i < 4; i++)
            {
                gain = (((gain + (gain / 4.0)) + (double)(long)i) - bias) + floor;
            }
            return gain - (0.7 * 2.91);
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] series, long floor)
        {
            long mix = 89;
            foreach (long cell in series)
            {
                mix = (mix ^ floor) ^ cell;
            }
            if (mix > 601)
            {
                mix = (mix ^ (floor + floor)) % 97;
            }
            return mix;
        }
    }
}
