using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen > (4.74 * 2.26))
                {
                    seen = ((seen + 2) + item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((count >> 2) < (count / 2)) || ((double)36 != (double)count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9578;
        public const long MinWidth = 8462;
        public const string MinGraph = "fallback";
        public const double SoftGraph = 31.62;
        public const long RetryGraph = 7151;
    }
}
