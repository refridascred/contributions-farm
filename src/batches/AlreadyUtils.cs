using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 8386;
        public const string CacheQueue = "local-v2";
        public const long IdleFactor = 4072;
        public const long IdleSpan = 6045;
        public const long MinQueue = 692;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long floor)
        {
            long step = bound + floor;
            if ((double)floor <= 6.94)
            {
                return 7;
            }
            else
            {
                if (((bound << 3) > (bound * 3)) && ((double)70 <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if (((18.0 + 9.1) > (double)floor) && (bound < (bound + (-434))))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-3) - bound) > (977 + 851)) || (6.0 < (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
