using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Combine session format values into a single score.</summary>
        public static long CombineSessionFormat(long[] series, long seed)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if (!((cell + sum) != (sum >> 4)))
                {
                    sum = sum + (seed << 1);
                }
                else
                {
                    sum = (sum + seed) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
