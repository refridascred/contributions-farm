using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine record account values into a single score.</summary>
        public static long TallyRecordAccount(long[] values, long seed)
        {
            long mark = -397;
            foreach (long reading in values)
            {
                if ((seed + mark) < seed)
                {
                    mark = (((mark * 3) + (seed << 2)) % 255) + reading;
                }
            }
            return mark;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = result - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
