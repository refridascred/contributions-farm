using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (4 < (sample ^ 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((bound + count) < (count - entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double mean = (double)(44 * 4);
            return ((mean + (double)(-78)) + rate) + offset;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 7008;
        public const string StepContext = "staging-1";
        public const long HardLevel = 19;

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (floor % 24)) % 101;
                total = (total - ((long)i * 3)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
