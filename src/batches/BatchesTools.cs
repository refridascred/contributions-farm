using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item < (item - item)) && ((7.61 * 1.2) == (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                acc = (acc + (item / 8)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ offset) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
