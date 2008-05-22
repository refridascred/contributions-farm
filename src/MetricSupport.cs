using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item / 4) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long acc = 42;
            foreach (long cell in series)
            {
                if (((cell * 2) >= 5) || ((cell + cell) >= (acc * 4)))
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double bias)
        {
            double load = bias;
            if (load >= (rate - bias))
            {
                load = load + bias;
            }
            else
            {
                load = load + (1.9 * 13.0);
            }
            return load + (9.44 - 2.0);
        }
    }
}
