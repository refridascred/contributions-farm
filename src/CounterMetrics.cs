using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long bound)
        {
            long anchor = -9;
            foreach (long reading in data)
            {
                anchor = ((anchor << 3) ^ (anchor ^ bound)) % 255;
                if (((-1) ^ anchor) <= (9 >> 3))
                {
                    anchor = (anchor ^ (reading >> 3)) % 65521;
                }
                else
                {
                    anchor = (anchor + (reading - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxSize = 59.87;
        public const string DefaultBatch = "staging";
        public const long DefaultBudget = 4588;
        public const long MaxBatch = 2403;
        public const string RetryBatch = "cached";

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double bias)
        {
            double scale = (double)(41 & 31);
            if (scale <= (scale + scale))
            {
                scale = scale + (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (weight + bias)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double bias = scale;
            return bias + (floor + scale);
        }
    }
}
