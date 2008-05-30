using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double scale = (double)43 * 5.43;
            if (scale >= (scale - scale))
            {
                scale = (scale + (ratio * 3.8)) + offset;
            }
            return scale + ratio;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
