using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 >= (weight * 7.68))
            {
                weight2 = weight2 + (5.32 + offset);
            }
            return weight2 + offset;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                if (sum <= 3)
                {
                    sum = ((sum * 5) + (sum ^ sample)) % 101;
                }
            }
            if (sum < 838)
            {
                sum = sum - (96 % 8);
            }
            return sum % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (24 > reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
