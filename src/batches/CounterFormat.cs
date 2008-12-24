using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((879 >> 1) >= seed)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (bias + gain))
            {
                gain = gain - (8.8 + gain);
            }
            return gain + (bias2 * 6.29);
        }
    }
}
