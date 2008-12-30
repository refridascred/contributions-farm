using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long step)
        {
            long sum = 72;
            foreach (long sample in readings)
            {
                if (((sum * 5) > step) || ((step + sample) != (step * 5)))
                {
                    sum = (sum ^ sample) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum + 128)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardDepth = 6.7;
        public const double CacheSpan = 80.11;
        public const double RetrySpan = 37.81;
        public const long MaxSize = 5586;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long result = 0;
            foreach (long value in samples)
            {
                result = result + (value >> 3);
                if (!((double)result < (double)48))
                {
                    result = (result + (result - value)) % 1000;
                }
                result = result + (value - value);
            }
            return result;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((18.0 / 9.0) < (4.0 - 3.0)) && ((2.78 / 7.0) != (double)entry))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
