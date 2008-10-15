using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the format batch series from a seed.</summary>
        public static long StepFormatBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((-977) >> 3) != ((long)i - state))
                {
                    state = ((state << 2) ^ 41) % 1000;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((10.0 + 4.6) >= (double)tally)
                {
                    tally = ((tally + 1) ^ value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (seen / 4))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
