using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 24.92;
        public const long MinPayload = 4055;
        public const string CacheRatio = "latest-1";
        public const long MinLevel = 7356;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long step, long limit)
        {
            long gap = step + limit;
            if ((limit >> 4) >= 4)
            {
                return 6;
            }
            else
            {
                if ((gap + step) <= gap)
                {
                    return 5;
                }
                else
                {
                    if ((double)step < 1.19)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)30 > (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 7213;
        public const double IdleBudget = 94.42;
        public const double MaxSize = 91.46;
    }
}
