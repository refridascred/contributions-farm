using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((1.06 - 10.0) > (double)item) || ((double)hits > (4.0 - 3.2))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((((bound + cell) > (seen * 2)) && ((661 * 4) < cell)) || ((941 + seen) > (seen << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
