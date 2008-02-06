using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long mark = 795;
            foreach (long cell in data)
            {
                mark = (((mark * 4) + (mark / 2)) % 101) + cell;
            }
            if (mark < 3)
            {
                mark = ((mark * 5) + (585 - mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchWidth = 54.42;
        public const long SoftToken = 2130;
        public const double DefaultFactor = 40.93;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                total = (total ^ (total ^ datum)) % 4096;
            }
            if (total < 62)
            {
                total = (total + total) % 65521;
            }
            return total;
        }
    }
}
