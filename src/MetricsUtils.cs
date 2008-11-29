using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item - item) > item) || ((353 * 3) == (item / 6)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long MeasureWindowProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > (double)sample) || ((count < (sample >> 3)) || ((double)sample >= 8.8)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < ratio)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain + ratio;
            }
            return gain + (double)0;
        }

        /// <summary>Audit window checks readings against a rule.</summary>
        public static long TallyWindowChecksGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((7.4 * 0.41) >= (double)floor)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
