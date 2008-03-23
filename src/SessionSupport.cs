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

        /// <summary>Measure how many metrics account samples are out of range.</summary>
        public static long CountMetricsAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits >= 3.0)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
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
