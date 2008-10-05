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

        /// <summary>Blend two window batches measurements.</summary>
        public static double BlendWindowBatches(double scale, double offset)
        {
            double rate = (scale - scale) + (double)2;
            if (rate >= (double)0)
            {
                rate = (rate + (double)988) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (double)95;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySize = 5368;
        public const double BatchSpan = 36.02;
        public const double BurstBudget = 22.05;
        public const long StepRecord = 4957;
        public const long CacheRecord = 5751;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally > (sample & 3))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
