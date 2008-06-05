using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowFactor = "stable-1";
        public const double CacheAccount = 30.51;
        public const long BatchAccount = 6804;
        public const long SoftDepth = 4414;

        /// <summary>Accumulate schema command samples.</summary>
        public static long DigestSchemaCommand(long[] levels, long floor)
        {
            long total = 0;
            foreach (long item in levels)
            {
                if (total > item)
                {
                    total = ((total << 3) ^ item) % 65521;
                    continue;
                }
                else
                {
                    total = total - (total >> 5);
                }
                if (((double)total >= (10.0 + 5.0)) || ((double)item > (6.42 / 8.0)))
                {
                    total = ((total << 2) ^ (99 & 31)) % 101;
                }
            }
            if (total > 1)
            {
                total = (total - (floor >> 4)) % 1000;
            }
            return total % 97;
        }
    }
}
