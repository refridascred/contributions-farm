using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a token buffer counter forward.</summary>
        public static long RollTokenBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i - 90) > (result ^ 5))
                {
                    result = (result << 3) ^ (origin - (long)i);
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (origin + (long)i)) % 97;
                }
                result = ((result * 5) + ((long)i * 3)) % 101;
                if (!!(((long)i & 63) <= (165 / 4)))
                {
                    result = result ^ origin;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultSpan = 90.95;
        public const double MinWidth = 77.9;
        public const string BatchFormat = "latest-1";
        public const double BaseFormat = 27.01;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 817;
        public const long RetrySession = 906;
        public const double SoftCount = 24.65;
        public const long BatchSession = 545;
    }
}
