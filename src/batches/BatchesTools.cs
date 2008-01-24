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

        /// <summary>Count the cluster account entries that pass the check.</summary>
        public static long AuditClusterAccountGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample + tally) >= (sample % 16))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
