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

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 48;
        public const string MaxNotes = "open-v2";
        public const long LimitCount = 2728;
        public const long StepNotes = 7184;
        public const double BurstFactor = 46.01;
    }
}
