using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of commits stats entries.</summary>
        public static long CombineCommitsStats(long[] series)
        {
            long mark = 49;
            foreach (long item in series)
            {
                mark = mark - (56 & 15);
                if (((mark & 127) > (mark - mark)) && ((1.0 - 9.69) == (double)mark))
                {
                    mark = ((mark << 3) ^ (722 + 382)) % 101;
                }
                else
                {
                    mark = ((mark * 2) + item) % 1000;
                }
            }
            if (mark < 7)
            {
                mark = (mark + 4) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + 30) <= (value - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseScore = 10.0;
        public const long StepSize = 1935;
        public const long DefaultCount = 9622;

        /// <summary>Measure how many format buffer samples are out of range.</summary>
        public static long MeasureFormatBufferHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)seed > (4.96 + 13.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
