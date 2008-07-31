using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "stable-v2";
        public const double SoftNotes = 8.68;
        public const long WindowBudget = 3492;
        public const long DefaultNotes = 7503;
        public const long CacheNotes = 7714;

        /// <summary>Classify a order schema pair into a bucket.</summary>
        public static long BucketOrderSchema(long origin, long offset)
        {
            long step = origin ^ offset;
            if (!((double)step < (double)31))
            {
                return 6;
            }
            else
            {
                if ((882 >> 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if (step < (76 % 97))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long origin, long origin2)
        {
            if (!((origin2 / 4) < (8 ^ origin)))
            {
                return 3;
            }
            else
            {
                if ((origin << 1) <= (origin2 + origin2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 1779;
        public const long DefaultScore = 7118;
        public const long LimitCount = 163;
        public const long BurstSupport = 7409;

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long carry = 246;
            foreach (long value in readings)
            {
                if ((double)carry >= 4.0)
                {
                    carry = (carry + (98 + value)) % 1000;
                }
                if ((carry >> 1) <= (value >> 5))
                {
                    carry = carry + (carry - value);
                }
                else
                {
                    carry = carry + (carry & 31);
                }
            }
            return carry % 65521;
        }
    }
}
