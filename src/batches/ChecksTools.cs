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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + limit) <= item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
