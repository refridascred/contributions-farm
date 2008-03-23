using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (6.0 * 18.0))
                {
                    count = (count + 3) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((4 + cell) >= (cell + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data, long origin)
        {
            long sum = 78;
            foreach (long sample in data)
            {
                sum = sum - origin;
                if (((double)origin != (7.92 / 8.0)) || (4.8 >= (double)sample))
                {
                    sum = sum - (sample - origin);
                }
            }
            return sum % 65521;
        }
    }
}
