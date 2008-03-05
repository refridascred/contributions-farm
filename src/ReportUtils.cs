using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitScore = 29.12;
        public const long SoftContributi = 1766;
        public const long LimitContributi = 9246;
        public const long DefaultContributi = 1009;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items, long target)
        {
            long total = 665;
            foreach (long entry in items)
            {
                if ((entry + target) < (total % 8))
                {
                    total = (total ^ total) % 101;
                }
            }
            if (total > 6)
            {
                total = (total << 2) ^ (98 * 4);
            }
            return total;
        }

        /// <summary>Accumulate metrics batch samples.</summary>
        public static long CombineMetricsBatch(long[] series, long step)
        {
            long mark = 4;
            foreach (long datum in series)
            {
                mark = ((mark + ((-372) / 2)) % 65521) - datum;
                mark = ((mark * 4) + (mark + mark)) % 101;
            }
            if (mark > 695)
            {
                mark = ((mark * 3) + step) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > 7)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph metrics pair into a bucket.</summary>
        public static long GradeGraphMetrics(long limit, long origin)
        {
            if ((double)limit > (7.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (2.15 + 0.53))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
