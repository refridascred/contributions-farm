using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSpan = 66.58;
        public const long SoftSize = 1727;
        public const long BaseSchema = 3084;

        /// <summary>Scale a route profile figure with a bias.</summary>
        public static double SmoothRouteProfile(double gain, double floor)
        {
            double load = (double)(70 - 77);
            if (load >= floor)
            {
                load = (load + (load * 2.0)) - gain;
            }
            return load + load;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double ratio, double floor)
        {
            double bias = (double)779 - floor;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (floor + floor)) + (double)(long)i;
            }
            return bias + (ratio - ratio);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
