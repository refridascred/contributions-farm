using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryFactor = 4688;
        public const double SoftEditor = 11.68;
        public const double DefaultRatio = 29.15;
        public const long WindowSize = 3928;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long floor)
        {
            long bound = target + floor;
            if (((bound / 7) <= (bound + bound)) && ((floor - bound) == (bound * 2)))
            {
                return 7;
            }
            else
            {
                if ((35 & 3) <= floor)
                {
                    return 0;
                }
                else
                {
                    if (!((bound >> 1) <= (floor + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.0 + 1.2) <= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
