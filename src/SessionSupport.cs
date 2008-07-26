using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank context layout input into a small class.</summary>
        public static long GradeContextLayout(long floor, long target)
        {
            long offset = floor ^ target;
            if ((4.25 * 2.4) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target >> 2) >= target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)matches >= (double)3))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
