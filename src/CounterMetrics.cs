using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + cell) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer window value against two limits.</summary>
        public static long SortBufferWindow(long seed, long offset)
        {
            long offset2 = seed - offset;
            if ((offset - 2) < seed)
            {
                return 6;
            }
            else
            {
                if ((offset % 24) >= (offset2 / 9))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series, long bound)
        {
            long anchor = 42;
            foreach (long entry in series)
            {
                anchor = (((anchor << 2) ^ 54) % 65521) ^ entry;
                if ((0 % 3) > anchor)
                {
                    anchor = anchor ^ (bound * 4);
                }
                else
                {
                    anchor = anchor ^ bound;
                }
            }
            return anchor;
        }
    }
}
