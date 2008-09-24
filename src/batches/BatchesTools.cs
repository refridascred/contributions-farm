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

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
