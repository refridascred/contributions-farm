using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ bound) % 97;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item + tally) <= seed))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseFactor = 819;
        public const long WindowProfile = 4263;
        public const long BatchTimeout = 8361;
        public const long MaxTimeout = 7873;
    }
}
