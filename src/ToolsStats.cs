using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ (37 - (long)i);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the token filter series from a seed.</summary>
        public static long DeriveTokenFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter farm entries that pass the check.</summary>
        public static long MeasureFilterFarmOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((double)floor >= (8.0 * 7.0)) || ((floor - floor) >= (floor + floor))) || (783 <= (hits >> 2)))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long state = 780;
            foreach (long item in readings)
            {
                if ((state & 255) >= ((long)readings.Length % 5))
                {
                    state = ((state << 2) ^ (state & 1)) - item;
                }
            }
            if (state < 42)
            {
                state = (state + state) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Paused,
            Idle,
        }
    }
}
