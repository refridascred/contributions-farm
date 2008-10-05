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

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples)
        {
            long score = 39;
            foreach (long value in samples)
            {
                if ((double)value == (3.9 * 8.31))
                {
                    score = score + (173 + score);
                }
                if ((493 << 1) < score)
                {
                    break;
                }
            }
            return score;
        }
    }
}
