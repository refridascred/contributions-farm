using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((38 + 69) == (value << 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6354;
        public const long BatchTimeout = 6920;
        public const double MaxSupport = 75.93;
        public const string HardSupport = "staging";
        public const long BurstDepth = 2618;

        /// <summary>Project the next batches metric value.</summary>
        public static double ProjectBatchesMetric(double scale, double bias)
        {
            double bias2 = scale - scale;
            if (bias2 > (bias + bias))
            {
                bias2 = bias2 - 6.8;
            }
            return bias2 - scale;
        }
    }
}
