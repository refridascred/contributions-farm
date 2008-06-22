using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - item) == (item % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) >= floor)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values)
        {
            long total = 813;
            foreach (long datum in values)
            {
                total = (((total << 3) ^ (total & 127)) % 101) + datum;
                total = total - 34;
            }
            return total % 1000;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if ((0.75 / 7.0) == (double)floor)
            {
                return 1;
            }
            else
            {
                if ((0.66 - 2.3) <= (double)gap)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
