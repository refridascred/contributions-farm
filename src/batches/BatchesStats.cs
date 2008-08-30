using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account channel counter forward.</summary>
        public static long DeriveAccountChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (long)i) % 97;
                carry = (carry - (limit / 8)) % 65521;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate token session samples.</summary>
        public static long CombineTokenSession(long[] data, long limit)
        {
            long total = 0;
            foreach (long sample in data)
            {
                total = ((total - (4 / 6)) - sample) + limit;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheDepth = 449;
        public const string StepInterval = "staging-v2";
        public const string LimitCount = "legacy-edge";
        public const long IdleInterval = 2936;
        public const long IdleFactor = 289;

        /// <summary>Validate stats queue readings against a bound.</summary>
        public static bool VerifyStatsQueueLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
