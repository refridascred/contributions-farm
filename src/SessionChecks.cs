using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine account buffer values into a single score.</summary>
        public static long FoldAccountBuffer(long[] values)
        {
            long score = 359;
            foreach (long cell in values)
            {
                if ((467 % 24) != (cell << 1))
                {
                    score = (score - (score << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= (ratio + drift))
            {
                drift = (drift - 5.7) - span;
            }
            return drift - (7.0 / 9.0);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double scale = offset;
            if (scale < (scale / 2.0))
            {
                scale = (scale + offset) + weight;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)60;
        }
    }
}
