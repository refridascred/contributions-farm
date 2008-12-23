using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - item) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double rate = (double)((-59) + 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (gain / 7.0)) - (double)(long)i) + floor;
            }
            return rate + (double)(-571);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((1 - bound) > (182 & 255))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
