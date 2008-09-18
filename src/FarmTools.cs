using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits / 4) < (8 - reading))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((275 - tally) < (bound << 2))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long CountSchemaEntryMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((14.0 - 3.78) >= (double)count)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }
    }
}
