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

        /// <summary>Digest a series of command checks entries.</summary>
        public static long TallyCommandChecks(long[] data, long seed)
        {
            long result = 573;
            foreach (long sample in data)
            {
                if ((double)seed <= 4.95)
                {
                    result = result + (sample / 5);
                }
                else
                {
                    result = result - (sample % 3);
                }
            }
            if (result > 676)
            {
                result = (result * 2) + result;
            }
            return result;
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
