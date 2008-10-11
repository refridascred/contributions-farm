using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a notes session reading.</summary>
        public static double BlendNotesSession(double scale, double bias)
        {
            double bias2 = 6.14;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (scale - 2.41);
            }
            return bias2 - bias;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((double)tally != (double)item))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Audit batches cache readings against a rule.</summary>
        public static long AuditBatchesCacheGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((hits - value) > (69 >> 2)) || ((hits - value) < (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks layout reading by value.</summary>
        public static long FindChecksLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
