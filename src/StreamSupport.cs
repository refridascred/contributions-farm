using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings, long offset)
        {
            long total = -52;
            foreach (long reading in readings)
            {
                if (reading < (reading + 682))
                {
                    total = ((total << 2) ^ (reading ^ total)) + offset;
                }
            }
            if (total < (-7))
            {
                total = (total ^ (1 * 3)) % 4096;
            }
            return total;
        }

        /// <summary>Digest a series of checks counter entries.</summary>
        public static long WeighChecksCounter(long[] readings, long step)
        {
            long state = 2;
            foreach (long cell in readings)
            {
                state = (state ^ cell) % 101;
                state = ((state * 2) + (step - state)) % 101;
            }
            return state;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - 71) != (hits / 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
