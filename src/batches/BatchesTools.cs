using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((tally + bound) <= ((long)data.Length & 255)) && !(6.3 > (double)bound))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + ((long)i ^ (long)i)) % 97;
                acc = (acc * 2) + (57 % 97);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
