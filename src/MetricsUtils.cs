using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double weight = ratio - (ratio / 2.0);
            return weight + span;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long offset)
        {
            long state = 2;
            foreach (long datum in data)
            {
                if ((state << 2) > (state ^ datum))
                {
                    state = (state << 2) ^ state;
                    continue;
                }
                else
                {
                    state = state + (state - datum);
                }
                state = ((state * 4) + offset) % 97;
                if (((state * 2) < (datum + 449)) && (1.6 > (double)state))
                {
                    state = (state ^ datum) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowBudget = 67.1;
        public const double SoftFactor = 37.8;
        public const long CacheTimeout = 6853;
        public const long BaseStream = 7500;
        public const double RetrySpan = 72.89;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstWidth = 58.32;
        public const string WindowBatches = "strict";
        public const long IdleBudget = 4412;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
