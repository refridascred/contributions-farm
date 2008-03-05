using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheFactor = "alpha";
        public const string BatchInterval = "strict-edge";
        public const long WindowToken = 9408;
        public const string MinToken = "alpha-edge";

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long target)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                carry = ((carry + carry) ^ sample) - target;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ (floor % 7);
                if ((floor * 2) < 8)
                {
                    result = ((result << 2) ^ (result >> 5)) % 101;
                }
                else
                {
                    result = (result - (97 << 3)) % 255;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Ready,
            Failed,
            Retry,
        }
    }
}
