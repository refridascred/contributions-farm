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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
