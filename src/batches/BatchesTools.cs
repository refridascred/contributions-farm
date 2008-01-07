using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long step, long origin)
        {
            long gap = step ^ origin;
            if (origin >= step)
            {
                return 4;
            }
            else
            {
                if (step > (origin + gap))
                {
                    return 5;
                }
                else
                {
                    if ((step < (85 + gap)) || ((step % 2) <= (step + gap)))
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
