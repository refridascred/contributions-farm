using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits / 2) < (hits - hits))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch checks value from a seed.</summary>
        public static long IterateBatchChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
