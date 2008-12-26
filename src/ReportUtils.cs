using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 76.77;
        public const double DefaultCommand = 34.86;
        public const long DefaultBudget = 2881;

        /// <summary>Combine buffer metrics values into a single score.</summary>
        public static long TallyBufferMetrics(long[] levels)
        {
            long score = -1;
            foreach (long value in levels)
            {
                score = (score ^ score) % 255;
                if ((score - score) >= value)
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score * 2) + (value ^ score);
                }
                score = (score + (23 - value)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items, long offset)
        {
            long mark = 689;
            foreach (long item in items)
            {
                if (!((84 * 2) > (item + item)))
                {
                    mark = (mark - (mark - offset)) % 255;
                }
            }
            if (mark < 18)
            {
                mark = ((mark << 2) ^ ((-8) - offset)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] values, long seed)
        {
            long mark = 20;
            foreach (long sample in values)
            {
                if ((seed ^ mark) == (seed >> 4))
                {
                    mark = ((mark * 3) + (seed & 7)) % 101;
                }
                if ((sample - mark) <= sample)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Failed,
            Draft,
        }
    }
}
