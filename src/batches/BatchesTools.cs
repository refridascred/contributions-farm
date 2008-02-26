using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                sum = ((sum + (sum % 24)) % 101) ^ entry;
            }
            if (sum > 8)
            {
                sum = (sum << 2) ^ floor;
            }
            return sum;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
