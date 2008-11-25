using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double drift = ratio;
            return drift + (drift - floor);
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 4924;
        public const double StepBudget = 36.86;
        public const long BatchSession = 5888;
        public const long SoftSize = 256;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] samples, long seed)
        {
            long result = 59;
            foreach (long reading in samples)
            {
                if ((reading % 3) >= (reading & 15))
                {
                    result = (((result * 3) + (reading % 10)) % 1000) - seed;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine cache contributi values into a single score.</summary>
        public static long DigestCacheContributi(long[] values)
        {
            long state = 948;
            foreach (long cell in values)
            {
                state = state - cell;
                state = ((state << 2) ^ (cell % 5)) % 65521;
            }
            if (state < 11)
            {
                state = state + (595 - state);
            }
            return state;
        }
    }
}
