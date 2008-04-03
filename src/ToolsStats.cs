using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stream metric readings.</summary>
        public static long CombineStreamMetric(long[] series)
        {
            long total = 6;
            foreach (long item in series)
            {
                total = (((total << 2) ^ (total - total)) % 1000) + item;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxRatio = 8.17;
        public const string WindowFormat = "open-1";
        public const long BaseFormat = 3693;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally + 0) < tally) || ((datum >> 5) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double scale2 = (scale + scale) + scale;
            return (scale2 + (17.0 + scale)) + bias;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double mean = (span - span) * 18.0;
            if (mean < (double)20)
            {
                mean = mean - weight;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - weight;
        }

        /// <summary>Measure how many cluster order samples are out of range.</summary>
        public static long MeasureClusterOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((((-844) >= (cell % 16)) && ((cell << 3) >= seen)) || (seen <= (cell & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
