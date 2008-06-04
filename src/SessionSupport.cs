using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches + reading) < origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long bound)
        {
            long mix = 880;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix * 5) + mix) % 65521) - (long)i;
                }
                if (!((11.0 * 15.0) >= (double)value))
                {
                    mix = (mix * 5) + (7 - bound);
                }
                mix = mix + mix;
            }
            return mix;
        }
    }
}
