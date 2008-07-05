using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseLevel = 87.08;
        public const double StepFilter = 12.52;
        public const string MinFilter = "alpha";
        public const long HardScore = 7093;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((-70) + mark) > (mark - mark))
                {
                    mark = (mark - mark) % 255;
                    mark = mark + (49 - mark);
                }
                else
                {
                    mark = mark ^ (mark % 64);
                }
                if (cell >= (cell / 3))
                {
                    mark = mark - mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((5 * 5) >= (5 + offset)) || (((long)series.Length + value) > (value << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
