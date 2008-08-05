using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double bias = span;
            if (bias > (double)89)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (0.59 + gain)) + (double)(long)i;
            }
            return bias - (bias * 13.0);
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels, long offset)
        {
            long carry = 125;
            foreach (long datum in levels)
            {
                carry = carry ^ (long)levels.Length;
                if (!((double)offset >= (double)carry))
                {
                    carry = (carry - offset) % 4096;
                }
                if ((datum / 5) > 1)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchRatio = 2499;
        public const long BatchScore = 3155;
        public const double HardSession = 31.52;

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleRatio = 27.05;
        public const long SoftFactor = 2284;
        public const long HardSchema = 7335;
    }
}
