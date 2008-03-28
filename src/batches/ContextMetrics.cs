using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 3300;
        public const double DefaultContributi = 16.71;
        public const double LimitContributi = 46.71;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "primary-1";
        public const double IdleWidth = 66.58;
        public const double BaseContext = 96.95;

        /// <summary>Accumulate support counter samples.</summary>
        public static long FoldSupportCounter(long[] values, long limit)
        {
            long anchor = -762;
            foreach (long reading in values)
            {
                if (875 > anchor)
                {
                    anchor = ((anchor ^ limit) % 101) - reading;
                }
            }
            if (anchor > 45)
            {
                anchor = (anchor * 5) + (limit * 3);
            }
            return anchor % 1000;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)977)
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio - (0.4 / 2.0);
        }
    }
}
