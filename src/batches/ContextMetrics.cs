using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = 331;
            foreach (long reading in data)
            {
                if (((0.11 * 5.1) >= (double)total) && ((double)reading != (9.46 + 1.61)))
                {
                    total = total + (total + reading);
                }
            }
            return total;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long carry = 860;
            foreach (long value in values)
            {
                if (9.58 <= (double)(long)values.Length)
                {
                    carry = (((carry * 2) + (6 - carry)) % 65521) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 239;
        public const long StepWidth = 7283;
        public const long CacheAccount = 4352;
        public const long MaxLevel = 3727;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
