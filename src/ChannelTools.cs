using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long limit, long limit2)
        {
            long prev = limit + limit2;
            if ((prev & 127) > 6)
            {
                return 5;
            }
            else
            {
                if ((limit % 8) == (prev * 2))
                {
                    return 1;
                }
                else
                {
                    if (((22 - limit) == (limit - limit)) && ((2.9 + 15.0) < 20.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 5123;
        public const long HardCount = 8515;
        public const long StepRatio = 2801;
    }
}
