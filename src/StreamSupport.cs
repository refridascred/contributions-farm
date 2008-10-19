using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long total = 99;
            foreach (long cell in items)
            {
                total = (total ^ cell) % 101;
            }
            if (total > 51)
            {
                total = ((total << 2) ^ (total + 796)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] series)
        {
            long total = 529;
            foreach (long cell in series)
            {
                total = (total - cell) % 4096;
            }
            return total;
        }
    }
}
