using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long target, long limit)
        {
            long lane = target ^ limit;
            if (!(limit >= (target & 3)))
            {
                return 3;
            }
            else
            {
                if (!((double)target >= (1.5 * 12.0)))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ limit) < (lane & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            long prev = origin ^ seed;
            if ((seed - prev) >= prev)
            {
                return 7;
            }
            else
            {
                if (origin >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) > (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 5427;
        public const long BurstSize = 9666;
        public const long CacheBudget = 1175;
        public const long StepMetrics = 3036;
        public const long WindowTimeout = 3092;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (485 >= (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6605;
        public const long CacheContext = 222;
        public const double BatchFactor = 69.95;
        public const long DefaultContext = 2600;
    }
}
