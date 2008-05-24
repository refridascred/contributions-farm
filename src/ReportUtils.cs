using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (item + item)) % 255;
            }
            if (sum > 15)
            {
                sum = (sum + (limit >> 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches % 100) == (reading << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series, long floor)
        {
            long acc = 0;
            foreach (long item in series)
            {
                if (item > (acc + floor))
                {
                    acc = acc - (acc + floor);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels)
        {
            long carry = 6;
            foreach (long datum in levels)
            {
                if (((6 >> 4) <= (datum >> 4)) && ((7.8 + 5.37) == (double)carry))
                {
                    carry = ((carry << 3) ^ (datum - carry)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (53 + datum)) % 1000;
                }
            }
            if (carry > 9)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 4096;
        }
    }
}
