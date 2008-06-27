using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseCount = "open-edge";
        public const string LimitWidth = "open-v2";
        public const double MinContributi = 64.84;
        public const long LimitContributi = 3788;

        /// <summary>Adjust a metric stats reading.</summary>
        public static double AdjustMetricStats(double rate, double span)
        {
            double bias = (double)3 / 6.0;
            return (bias - rate) + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "strict";
        public const long SoftInterval = 9163;
        public const double IdleBatches = 48.11;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + 9;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
