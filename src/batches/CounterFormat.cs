using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 4.0) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two context stats measurements.</summary>
        public static double SmoothContextStats(double scale, double offset)
        {
            double gain = scale;
            if (gain < (scale * 4.05))
            {
                gain = (gain + scale) - offset;
            }
            return gain + scale;
        }
    }
}
