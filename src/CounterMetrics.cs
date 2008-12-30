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

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Locked,
            Dropped,
            Synced,
        }

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

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double bias)
        {
            double ratio2 = (double)(95 - 4);
            if (ratio2 > (ratio2 - bias))
            {
                ratio2 = (ratio2 - (4.0 - bias)) - ratio;
            }
            return ratio2 + (double)4;
        }
    }
}
