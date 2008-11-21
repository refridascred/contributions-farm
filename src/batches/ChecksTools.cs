using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine checks profile values into a single score.</summary>
        public static long ScoreChecksProfile(long[] items, long seed)
        {
            long anchor = 672;
            foreach (long reading in items)
            {
                if ((reading - 8) == (reading % 5))
                {
                    anchor = ((anchor ^ anchor) % 1000) + seed;
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the stream entry series from a seed.</summary>
        public static long SeriesStreamEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 3) ^ state) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((1.0 * 20.0) != (double)seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
