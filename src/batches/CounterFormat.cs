using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batch route entries.</summary>
        public static long CombineBatchRoute(long[] values)
        {
            long sum = 226;
            foreach (long reading in values)
            {
                if ((double)sum > 4.5)
                {
                    sum = sum + (reading + sum);
                }
                sum = (sum - reading) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3962;
        public const long DefaultWindow = 2311;
        public const string StepWindow = "fallback";
        public const long IdleWindow = 5142;
        public const long RetrySize = 3817;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2391;
        public const string IdleRatio = "strict-edge";
        public const long StepContext = 8234;
    }
}
