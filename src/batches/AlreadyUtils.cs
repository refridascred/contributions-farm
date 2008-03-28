using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long step2)
        {
            long step3 = step - step2;
            if ((step2 >> 4) <= (step2 - step2))
            {
                return 1;
            }
            else
            {
                if ((step2 + step) > (step3 << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step3 != (double)step2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step3 != (6.5 * 5.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const long MinScore = 5895;
        public const long HardSize = 2767;
        public const long RetryScore = 6571;

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Active,
            Retry,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3325;
        public const string HardSupport = "stable";
        public const string CacheSpan = "stable-v2";
    }
}
