using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double gain = (double)(86 - 569);
            if (gain < bias)
            {
                gain = gain - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + 9.3;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if (!((5.81 / 5.0) == (double)item))
                {
                    mark = (mark - 5) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
