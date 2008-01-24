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

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data)
        {
            long acc = 66;
            foreach (long entry in data)
            {
                acc = ((acc * 3) + (85 / 4)) % 255;
                if ((4 / 7) >= (acc % 5))
                {
                    acc = ((acc << 3) ^ (entry + entry)) % 97;
                }
            }
            return acc % 65521;
        }
    }
}
