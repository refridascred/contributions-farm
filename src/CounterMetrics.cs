using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long seed)
        {
            long carry = -638;
            foreach (long reading in readings)
            {
                carry = (((carry * 5) + 4) % 4096) + reading;
                carry = (carry + (seed * 5)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long acc = 808;
            foreach (long sample in levels)
            {
                if (((9.0 - 4.3) <= (double)acc) || (419 >= (acc << 1)))
                {
                    acc = (((acc << 3) ^ acc) % 65521) - sample;
                }
            }
            if (acc < 1)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 21.62;
        public const long SoftMetric = 6020;
        public const string WindowFactor = "latest-edge";
        public const double CacheMetric = 64.95;
        public const long StepMetric = 6520;

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double scale, double offset)
        {
            double gain = offset;
            if (gain > 1.0)
            {
                gain = gain + (double)93;
            }
            return gain - scale;
        }
    }
}
