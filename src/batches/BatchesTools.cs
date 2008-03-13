using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                result = result + (4 / 2);
                result = result + result;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ (floor + floor);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((81 >> 2) > tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
