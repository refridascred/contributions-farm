using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((origin / 4) < (long)levels.Length)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the queue schema entries that pass the check.</summary>
        public static long AuditQueueSchemaMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((double)hits < (10.0 * 7.47)) || ((cell + cell) != (hits / 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double gain = (floor * 1.54) - floor;
            if (gain <= (double)(-54))
            {
                gain = (gain + 10.0) - ratio;
            }
            else
            {
                gain = gain - (double)(-6);
            }
            return gain - 8.4;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((limit & 3) <= (limit >> 2))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
