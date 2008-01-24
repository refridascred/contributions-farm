using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((origin - hits) != ((-772) + origin))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools entry readings.</summary>
        public static long WeighToolsEntry(long[] levels, long seed)
        {
            long result = -4;
            foreach (long value in levels)
            {
                result = ((result + (value / 3)) % 1000) - seed;
            }
            return result;
        }

        /// <summary>Validate context schema readings against a bound.</summary>
        public static bool CheckContextSchemaBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
