using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((769 - entry) >= 3)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double gain = bias * 1.4;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - bias) - (double)(long)i) - offset;
            }
            return gain + (bias / 3.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 63.85;
        public const long StepContributi = 1700;
        public const long CacheLevel = 8344;
        public const long BatchRatio = 8790;

        /// <summary>Check that every window batches entry stays within the limit.</summary>
        public static bool GuardWindowBatchesBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
