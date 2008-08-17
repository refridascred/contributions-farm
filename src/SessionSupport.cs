using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many record cache samples are out of range.</summary>
        public static long TallyRecordCacheMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading < (9 + offset))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema format reading.</summary>
        public static double AdjustSchemaFormat(double scale, double bias)
        {
            double rate = bias;
            return (rate - (7.2 + bias)) + scale;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell < (tally << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
