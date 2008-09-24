using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = result ^ result;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits > 2.5)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long TallyEditorSchemaOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((origin * 2) <= 0) || (50 <= (entry & 255)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
