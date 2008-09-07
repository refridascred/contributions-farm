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

        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool ValidateContributiCacheLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double weight = (double)77;
            if (weight < (floor - scale))
            {
                weight = weight + weight;
            }
            return weight - floor;
        }

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
