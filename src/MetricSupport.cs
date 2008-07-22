using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double gain = 15.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (floor / 7.0)) + (double)(long)i) + scale;
            }
            return gain - (double)2;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 8920;
        public const long WindowFactor = 3211;
        public const long DefaultScore = 2632;
        public const double BatchDepth = 77.07;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((94 ^ count) <= (count + step))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
