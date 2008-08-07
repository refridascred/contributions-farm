using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 55.39;
        public const double DefaultAccount = 69.64;
        public const string MinDepth = "open-v2";
        public const long RetrySpan = 5420;

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double drift = (double)(987 >> 2);
            if (drift >= (rate + drift))
            {
                drift = drift - (drift - offset);
            }
            else
            {
                drift = drift - 7.71;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)326) + (double)(long)i;
            }
            return drift - (double)847;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + seen) <= (seen - cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Paused,
            Pending,
            Idle,
            Stale,
        }
    }
}
