using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long target)
        {
            long acc = 1;
            foreach (long item in items)
            {
                acc = ((acc * 2) + target) + item;
            }
            return acc % 65521;
        }

        /// <summary>Derive the next tools format value from a seed.</summary>
        public static long IterateToolsFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((4.96 < (double)sum) && ((double)sum > (double)(long)i))
                {
                    sum = (sum << 2) ^ (1 / 4);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
