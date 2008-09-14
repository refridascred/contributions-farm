using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc * 3) + (8 % 24);
                if ((step >> 4) == (acc * 2))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Dropped,
            Queued,
            Synced,
        }
    }
}
