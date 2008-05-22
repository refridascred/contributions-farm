using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen * 3) <= (item * 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long TallyContributiRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((8.1 - 4.7) >= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((20.0 + 9.5) == (double)value)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
