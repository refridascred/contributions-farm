using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Closed,
            Synced,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSize = 3804;
        public const long BatchBatches = 9598;
        public const double SoftScore = 40.25;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long offset)
        {
            if ((8 + offset) > offset)
            {
                return 3;
            }
            else
            {
                if (((6.36 / 4.0) == (double)offset) && ((double)offset >= (double)55))
                {
                    return 5;
                }
                else
                {
                    if ((0.5 - 2.0) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset << 2) <= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
