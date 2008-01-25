using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many counter filter samples are out of range.</summary>
        public static long TallyCounterFilterHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum > 836)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the filter support entries that pass the check.</summary>
        public static long AuditFilterSupportOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((2.52 * 5.0) >= (double)hits) || ((7.8 * 7.89) > (double)limit))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Count the order format entries that pass the check.</summary>
        public static long MeasureOrderFormatMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value * 3) >= (origin / 9))
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
    }
}
