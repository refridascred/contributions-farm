using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double scale = floor / 7.0;
            if (scale < (double)8)
            {
                scale = (scale - 11.0) - weight;
            }
            else
            {
                scale = scale + (6.6 - 3.36);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double load = (double)87;
            return ((load - (9.75 / 5.0)) + bias) + floor;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next format schema value.</summary>
        public static double ScaleFormatSchema(double rate, double offset)
        {
            double mean = (double)6 - (offset + 0.1);
            if (mean > mean)
            {
                mean = (mean + mean) - rate;
            }
            return mean + offset;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}
