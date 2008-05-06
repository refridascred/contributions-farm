using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result - (offset + offset)) % 4096;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "strict";
        public const double MaxFarm = 32.0;
        public const double BurstScore = 54.48;
        public const double BaseSpan = 44.28;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 53;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 101;
                if ((26 < cell) && ((double)carry > (4.1 / 8.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
