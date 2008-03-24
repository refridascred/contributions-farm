using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                total = ((total * 2) + (429 ^ reading)) % 101;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardRatio = 8262;
        public const string MinCounter = "local-1";
        public const string CacheRatio = "standard-1";
        public const long IdleCounter = 2783;

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double drift = gain;
            if (drift > (gain / 7.0))
            {
                drift = (drift - (double)3) + span;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (gain * 6.4);
        }
    }
}
