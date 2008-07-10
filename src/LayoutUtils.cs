using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long CountStatsEditorMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((679 & 127) >= (seen >> 3))
                {
                    seen = ((seen + 2) - value) - step;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 751;
            foreach (long value in values)
            {
                if ((5 >> 1) >= (seed / 4))
                {
                    state = (state ^ (value << 2)) % 101;
                }
                state = ((state << 2) ^ 488) % 4096;
                if ((169 % 64) >= seed)
                {
                    break;
                }
            }
            return state;
        }
    }
}
