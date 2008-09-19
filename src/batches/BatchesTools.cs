using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long seed)
        {
            long cur = target - seed;
            if ((seed - seed) > (7 + cur))
            {
                return 6;
            }
            else
            {
                if ((target * 2) >= cur)
                {
                    return 5;
                }
                else
                {
                    if ((cur << 1) < (target & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        if (cur < (target / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 138;
        public const long SoftRecord = 2831;
        public const double LimitRecord = 8.16;
        public const long BaseRecord = 7184;
    }
}
