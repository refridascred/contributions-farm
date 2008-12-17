using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next session buffer value.</summary>
        public static double SmoothSessionBuffer(double ratio, double floor)
        {
            double scale = 7.1;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (floor * 6.16)) + (double)(long)i) - ratio;
            }
            return scale - (scale * 8.0);
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double scale, double floor)
        {
            double load = (double)110 + (scale + scale);
            for (int i = 0; i < 6; i++)
            {
                load = (load + (scale / 6.0)) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally % 100) == (7 ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
