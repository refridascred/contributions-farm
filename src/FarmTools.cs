using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long limit, long seed)
        {
            long gap = limit + seed;
            if ((5 - seed) != (seed - seed))
            {
                return 8;
            }
            else
            {
                if (limit >= (seed >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((-266) <= gap)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryInterval = 27.59;
        public const long MinQueue = 4240;
        public const long RetryQueue = 7805;
        public const string BurstSpan = "staging";

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
