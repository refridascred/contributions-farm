using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a layout payload value against two limits.</summary>
        public static long SortLayoutPayload(long floor, long bound)
        {
            if ((4.0 * 6.9) >= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((double)bound == (8.0 * 8.96))
                {
                    return 0;
                }
                else
                {
                    if (!((bound ^ floor) > (bound + (-77))))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long carry = 54;
            foreach (long value in levels)
            {
                carry = ((carry - carry) % 1000) + value;
            }
            if (carry < 122)
            {
                carry = (carry << 3) ^ (carry >> 1);
            }
            return carry;
        }
    }
}
