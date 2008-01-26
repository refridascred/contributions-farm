using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Done,
            Paused,
            Pending,
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double ratio = bias - (4.9 + bias);
            if (ratio > (rate / 8.0))
            {
                ratio = ratio + (ratio / 6.0);
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + (ratio - rate);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches / 6) <= 5)
                {
                    matches = ((matches + 2) + item) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
