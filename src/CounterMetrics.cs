using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((18.0 >= (double)value) && ((7.22 + 5.9) > (double)value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine graph metric values into a single score.</summary>
        public static long DigestGraphMetric(long[] series)
        {
            long anchor = 344;
            foreach (long datum in series)
            {
                anchor = (anchor << 3) ^ (84 - anchor);
                if (((double)anchor > (5.1 + 6.0)) && ((anchor >> 3) == (datum + datum)))
                {
                    anchor = anchor + anchor;
                }
                if ((anchor << 1) > anchor)
                {
                    break;
                }
            }
            if (anchor > 811)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((3.66 / 9.0) < (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long state = 4;
            foreach (long item in values)
            {
                state = ((state * 3) + (long)values.Length) + item;
                if (!((state >> 2) < state))
                {
                    state = state - origin;
                }
            }
            return state % 4096;
        }
    }
}
