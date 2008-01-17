using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally == (6.1 - 9.0))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((datum + datum) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] values)
        {
            long mark = -6;
            foreach (long datum in values)
            {
                if ((datum - mark) < datum)
                {
                    mark = (mark - mark) % 65521;
                }
            }
            if (mark > 4)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const long HardProfile = 2898;
        public const string WindowSize = "legacy-v2";
        public const long BatchProfile = 1167;
    }
}
