using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if ((9.0 + 2.7) != (double)seed)
                {
                    carry = (carry + (seed / 2)) ^ value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Closed,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i > score))
                {
                    score = ((score * 3) + (score - (long)i)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ 7) % 101;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate stream layout readings against a bound.</summary>
        public static bool VerifyStreamLayoutRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 9709;
        public const long SoftReport = 2994;
        public const long StepRatio = 6023;
    }
}
