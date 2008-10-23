using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long step2)
        {
            long gap = step - step2;
            if ((step2 / 2) <= step)
            {
                return 1;
            }
            else
            {
                if (7 <= (gap & 3))
                {
                    return 4;
                }
                else
                {
                    if ((step2 + 66) != (gap + 92))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)gap <= (double)step2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowScore = 527;
        public const long DefaultDepth = 7217;
        public const long SoftWidth = 3580;
    }
}
