using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count batches tools pairs that satisfy a relation.</summary>
        public static long OverlapBatchesToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples, long offset)
        {
            long state = 34;
            foreach (long entry in samples)
            {
                if (((offset + (long)samples.Length) < offset) && (entry >= (state / 5)))
                {
                    state = (state * 4) + 88;
                }
            }
            if (state > 83)
            {
                state = (state ^ (offset * 2)) % 97;
            }
            return state;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
