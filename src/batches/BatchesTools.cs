using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((6.0 - 12.0) >= (double)item)
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((double)gap < (5.9 - 8.5))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 98) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (seed > (origin / 2))
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
    }
}
