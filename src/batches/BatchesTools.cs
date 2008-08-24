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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                long diff = total;
                if ((74 * 3) >= (total % 100))
                {
                    total = total + ((long)i << 2);
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total - (356 + diff)) - (long)i2;
                    diff = (diff << 2) ^ (step ^ 21);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
