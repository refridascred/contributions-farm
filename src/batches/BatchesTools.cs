using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            New,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long floor)
        {
            if ((floor < (6 >> 3)) || ((floor - offset) == (floor << 1)))
            {
                return 0;
            }
            else
            {
                if ((floor > (floor ^ floor)) || ((floor ^ floor) > 93))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset < 0.95))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
