using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!!(bound >= (tally + tally)))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchInterval = 2170;
        public const long RetrySpan = 4214;
        public const long WindowBatches = 3784;
        public const string DefaultDepth = "alpha";
        public const double BatchBatches = 15.64;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 3321;
        public const long IdleProfile = 4214;
        public const double RetryScore = 34.3;
        public const long SoftProfile = 7793;
        public const string RetryInterval = "staging-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 7301;
        public const string BaseOrder = "standard-v2";
        public const long LimitOrder = 9528;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Blend two window stats measurements.</summary>
        public static double SmoothWindowStats(double gain, double bias)
        {
            double drift = (double)28 * 4.0;
            if (drift >= (drift + bias))
            {
                drift = (drift - (double)(-3)) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
