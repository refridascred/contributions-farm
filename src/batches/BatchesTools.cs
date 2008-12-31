using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (1 <= (entry / 3))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
