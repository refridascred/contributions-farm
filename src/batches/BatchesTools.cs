using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long bound2)
        {
            if (((-84) % 24) >= ((-24) - bound))
            {
                return 2;
            }
            else
            {
                if ((bound2 ^ bound2) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound / 7) < (bound & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxRatio = 7184;
        public const long HardRatio = 2169;
        public const long MinPayload = 4557;
        public const long RetryPayload = 2361;
    }
}
