using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally ^ value) >= (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (8 >= (limit + seen))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseScore = 42.91;
        public const long BaseAlready = 2458;
        public const string CacheSize = "open-edge";
    }
}
