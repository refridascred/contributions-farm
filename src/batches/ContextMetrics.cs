using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double floor)
        {
            double weight = bias;
            if (weight <= (bias * 0.7))
            {
                weight = (weight - bias) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight / 5.0)) + (double)(long)i;
            }
            return weight + 4.0;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5939;
        public const long BaseBudget = 9996;
        public const long DefaultMetrics = 49;
        public const string BaseMetrics = "stable-v2";
        public const long IdleTimeout = 7877;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= span)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (3.0 * 8.5);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (((anchor * 3) + (offset ^ offset)) % 255) ^ (long)i2;
                    anchor = (anchor ^ (offset + offset)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
