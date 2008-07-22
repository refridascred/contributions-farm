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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value & 1) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
