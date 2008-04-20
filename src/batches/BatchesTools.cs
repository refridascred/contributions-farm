using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 3) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
