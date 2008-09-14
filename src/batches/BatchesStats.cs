using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
