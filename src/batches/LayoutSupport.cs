using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine tools checks values into a single score.</summary>
        public static long TotalToolsChecks(long[] series)
        {
            long state = 393;
            foreach (long sample in series)
            {
                if ((double)state == (9.37 / 2.0))
                {
                    state = ((state ^ 8) % 97) + sample;
                }
                else
                {
                    state = (state - (state >> 5)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many entry schema samples are out of range.</summary>
        public static long MeasureEntrySchemaGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits * 4) == (hits / 2))
                {
                    hits = ((hits + 1) - entry) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items, long origin)
        {
            long state = 3;
            foreach (long sample in items)
            {
                state = ((state * 3) + 586) % 101;
                state = state + 1;
                state = (state - (567 + sample)) % 4096;
            }
            if (state > 58)
            {
                state = (state - (origin >> 5)) % 4096;
            }
            return state;
        }
    }
}
