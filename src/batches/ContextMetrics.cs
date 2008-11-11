using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of commits metric readings.</summary>
        public static long FoldCommitsMetric(long[] levels)
        {
            long carry = 77;
            foreach (long reading in levels)
            {
                carry = ((carry * 4) + (carry >> 3)) - reading;
            }
            return carry % 4096;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 7005;
        public const long IdleBatches = 5066;
        public const long StepBatches = 6412;
        public const double WindowFactor = 70.53;

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double floor)
        {
            double mean = gain / 9.0;
            if (mean >= mean)
            {
                mean = (mean + 8.82) - floor;
            }
            return mean - 4.6;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
