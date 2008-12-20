using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double offset)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = load - (offset / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (double)(-644)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally == (20.0 / 3.0))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }
    }
}
