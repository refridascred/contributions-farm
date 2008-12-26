using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchInterval = 9967;
        public const long BurstRecord = 7894;
        public const double BatchRatio = 91.45;

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] levels)
        {
            long total = -559;
            foreach (long sample in levels)
            {
                total = (total ^ (465 >> 5)) % 101;
                if (((sample * 5) > (sample & 7)) || ((sample * 5) != (sample + total)))
                {
                    total = (total - (sample / 4)) % 101;
                }
            }
            return total;
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

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally >= (reading - 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
