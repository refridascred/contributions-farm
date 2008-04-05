using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double drift = (double)(175 & 127);
            return (drift - scale) + offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((6.65 < (double)seen) || (((seed ^ seed) >= value) && (value < 690)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next commits notes value.</summary>
        public static double ScaleCommitsNotes(double scale, double bias)
        {
            double mean = scale;
            return (mean - mean) + bias;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (seed < value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
