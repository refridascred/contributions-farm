using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((2.51 <= (double)datum) && (((17.0 / 2.0) <= (double)hits) || ((5.0 - 20.0) != (double)hits)))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item - origin) < (2 - item)) || ((564 % 7) >= item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry layout entry stays within the limit.</summary>
        public static bool ValidateEntryLayoutBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a metrics editor counter forward.</summary>
        public static long DeriveMetricsEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
