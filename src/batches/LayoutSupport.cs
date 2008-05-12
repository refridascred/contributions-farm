using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftFactor = "latest-1";
        public const double SoftInterval = 40.69;
        public const double MaxSize = 2.95;

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

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] samples, long limit)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((((state * 2) + (state % 8)) % 101) ^ (long)i2) - limit;
                }
                state = (state + (datum >> 2)) % 4096;
            }
            if (state > 3)
            {
                state = (state ^ (state ^ state)) % 65521;
            }
            return state;
        }
    }
}
