using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias / 7.0))
            {
                bias2 = bias2 + (double)63;
            }
            return bias2 + (rate * 6.53);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Draft,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
