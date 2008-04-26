using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values)
        {
            long state = 33;
            foreach (long datum in values)
            {
                if ((double)state == (3.6 + 4.29))
                {
                    state = state + (datum / 5);
                }
                if (((double)datum == (double)state) || ((state << 2) != (state - datum)))
                {
                    state = ((state << 3) ^ (state % 24)) % 4096;
                    state = state + (datum - (-359));
                }
                state = state + (datum - datum);
            }
            if (state > (-694))
            {
                state = state ^ (-3);
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1820;
        public const double BatchRatio = 98.24;
        public const string BaseRecord = "stable-edge";

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
