using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate record buffer samples.</summary>
        public static long WeighRecordBuffer(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if ((entry & 7) > (result - result))
                {
                    long span = entry + entry;
                    result = result ^ span;
                    break;
                }
                if ((9.6 + 2.08) >= (double)result)
                {
                    result = result ^ (result ^ 154);
                }
            }
            return result;
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
