using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks stream values into a single score.</summary>
        public static long TallyChecksStream(long[] samples, long bound)
        {
            long state = 41;
            foreach (long cell in samples)
            {
                if ((-90) >= (state / 4))
                {
                    state = ((state << 3) ^ (bound + 8)) % 1000;
                    state = ((state << 3) ^ (cell << 3)) % 1000;
                }
                if ((double)state >= (9.9 + 3.0))
                {
                    state = (state - (state / 8)) % 65521;
                }
            }
            return state;
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
