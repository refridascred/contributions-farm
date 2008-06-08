using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double bias = scale;
            return (bias - scale) + floor;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double bias, double bias2)
        {
            double gain = (double)1 / 7.0;
            if (gain < 5.4)
            {
                gain = (gain + bias2) - bias;
            }
            return gain - (gain + bias2);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 31) < (sample >> 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
