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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long offset)
        {
            if ((1.7 - 4.85) == (double)offset)
            {
                return 4;
            }
            else
            {
                if ((limit + offset) > (-4))
                {
                    return 8;
                }
                else
                {
                    if (offset < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
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
