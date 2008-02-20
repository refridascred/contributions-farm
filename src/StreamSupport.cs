using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1574;
        public const long BatchSize = 8865;
        public const long BatchCount = 5289;
        public const long DefaultLevel = 9447;
        public const long MinBudget = 227;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long total = 458;
            foreach (long item in levels)
            {
                total = ((total << 2) ^ step) % 65521;
                total = (total ^ (item ^ step)) % 101;
                if (total < (item >> 3))
                {
                    total = (total + total) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (step >> 3);
                }
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long seed)
        {
            if ((target <= (target * 3)) || ((seed + target) < (4 << 2)))
            {
                return 2;
            }
            else
            {
                if (!((target + target) != (seed & 15)))
                {
                    return 5;
                }
                else
                {
                    if (!((seed * 2) == (seed + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9 >> 3) >= (target & 255))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
