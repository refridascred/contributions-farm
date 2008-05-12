using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a profile stats reading.</summary>
        public static double ScaleProfileStats(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + (4.7 * 13.0)) + floor;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + (floor / 2)) % 65521;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
