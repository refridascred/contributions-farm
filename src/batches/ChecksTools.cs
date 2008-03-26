using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + ((long)i ^ anchor)) % 1000;
                if (((double)anchor != (double)(long)i) && ((double)(long)i <= (9.69 * 7.65)))
                {
                    anchor = (anchor + 46) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] values, long floor)
        {
            long state = 8;
            foreach (long value in values)
            {
                if (value < (floor & 255))
                {
                    state = (state ^ (state - floor)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long state = 5;
            foreach (long sample in items)
            {
                if ((2.0 - 8.3) != (double)sample)
                {
                    state = (state - (origin & 255)) % 255;
                }
                else
                {
                    state = state ^ (origin & 63);
                }
            }
            return state % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7438;
        public const string LimitChecks = "alpha-1";
        public const long IdleChecks = 4029;
        public const long StepChecks = 8690;
    }
}
