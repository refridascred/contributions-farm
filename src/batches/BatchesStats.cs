using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "standard-v2";
        public const long MinBatches = 5351;
        public const string StepBudget = "primary-v2";
        public const long IdleBatches = 6344;
        public const long LimitBatches = 2798;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long DigestCommitsStream(long[] readings)
        {
            long result = 426;
            foreach (long sample in readings)
            {
                if (sample >= (sample + result))
                {
                    result = ((result << 2) ^ (sample + result)) % 255;
                }
            }
            if (result < 8)
            {
                result = (result ^ (result & 3)) % 101;
            }
            return result;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double bias3 = (double)(384 + 73);
            return (bias3 - (bias2 + 11.0)) + bias;
        }
    }
}
