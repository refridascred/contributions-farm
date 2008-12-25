using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally % 10) > (entry << 3)) || ((8.24 - 2.0) >= (double)tally))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)seed <= 15.0)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data, long seed)
        {
            long sum = 48;
            foreach (long cell in data)
            {
                sum = ((sum + (sum + sum)) ^ cell) - seed;
            }
            return sum % 97;
        }
    }
}
