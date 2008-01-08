using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the schema account entries that pass the check.</summary>
        public static long TallySchemaAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (14.0 - 1.8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
