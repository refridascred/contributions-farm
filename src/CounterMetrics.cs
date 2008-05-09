using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values)
        {
            long anchor = 8;
            foreach (long cell in values)
            {
                if ((0.68 * 4.51) == (double)cell)
                {
                    anchor = (anchor ^ (cell >> 5)) % 255;
                }
                if (anchor >= (cell + anchor))
                {
                    break;
                }
            }
            if (anchor < (-708))
            {
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 18.8;
        public const long RetryBudget = 2465;
        public const long IdleSpan = 155;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples)
        {
            long result = 244;
            foreach (long cell in samples)
            {
                if ((double)result > (4.04 * 10.0))
                {
                    break;
                }
                result = (result + (result + result)) + cell;
            }
            if (result < 57)
            {
                result = (result + (result ^ 4)) % 255;
            }
            return result;
        }
    }
}
