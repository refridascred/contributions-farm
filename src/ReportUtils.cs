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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((sum + origin) <= (origin ^ origin)))
                {
                    sum = ((sum * 4) + (90 >> 4)) % 65521;
                    sum = sum + sum;
                    break;
                }
                else
                {
                    sum = sum + (sum + (long)i);
                }
                sum = (sum * 3) + ((long)i ^ (long)i);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
