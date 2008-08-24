using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double gain = floor;
            return gain + (bias * 5.2);
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 3) < value)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
