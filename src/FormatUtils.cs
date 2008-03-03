using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultTimeout = 68.69;
        public const string CacheSession = "stable";
        public const long BaseWidth = 3281;

        /// <summary>Project the next command session value.</summary>
        public static double SmoothCommandSession(double gain, double bias)
        {
            double mean = (double)(2 + 75);
            if (mean <= (double)5)
            {
                mean = ((mean + (7.1 - mean)) - gain) + bias;
            }
            return mean + mean;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 903;
            foreach (long entry in levels)
            {
                carry = carry - (entry - carry);
                if (carry < ((long)levels.Length + entry))
                {
                    break;
                }
            }
            if (carry < 29)
            {
                carry = (carry + (170 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many report metrics samples are out of range.</summary>
        public static long MeasureReportMetricsHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - tally) > tally))
                {
                    tally = ((tally + 2) - sample) + floor;
                }
            }
            return tally;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((0.4 * 8.7) != (double)carry)
                {
                    carry = (carry + (780 ^ 3)) % 1000;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a profile report counter forward.</summary>
        public static long IterateProfileReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
