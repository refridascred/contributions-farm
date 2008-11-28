using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + 8) != (datum - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ ((long)i << 2);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate profile session samples.</summary>
        public static long DigestProfileSession(long[] values, long origin)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                if (((1.85 - 0.42) <= (double)cell) && ((double)origin <= (double)anchor))
                {
                    anchor = (anchor << 2) ^ (cell - anchor);
                }
                else
                {
                    anchor = (anchor + 509) % 1000;
                }
                if ((cell << 3) <= cell)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
