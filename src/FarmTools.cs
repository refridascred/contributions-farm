using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally / 3) == (37 + reading)))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double bias, double span)
        {
            double ratio = bias;
            if (ratio < ratio)
            {
                ratio = (ratio - (double)7) - span;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - (8.8 * 4.08);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 8960;
        public const double RetryTimeout = 74.53;
        public const long LimitCommits = 1706;
    }
}
