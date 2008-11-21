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

        /// <summary>Project the next entry metric value.</summary>
        public static double SmoothEntryMetric(double bias, double floor)
        {
            double bias2 = (bias * 3.3) - (bias + bias);
            if (bias2 <= (floor / 4.0))
            {
                bias2 = bias2 + bias;
            }
            return bias2 - floor;
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
