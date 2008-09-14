using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the schema already entries that pass the check.</summary>
        public static long TallySchemaAlreadyHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)limit < (9.1 + 0.94))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length & 255) >= 905)
                {
                    count = ((count + 1) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item >> 2) == ((-133) + item))
                {
                    seen = seen + 2;
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
