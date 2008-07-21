using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data, long target)
        {
            long sum = 58;
            foreach (long item in data)
            {
                sum = (((sum + (78 & 63)) % 97) ^ item) + target;
            }
            if (sum < 6)
            {
                sum = (sum - (sum - sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 843;
        public const string BaseTimeout = "local-edge";
        public const long BurstFormat = 3271;
        public const string StepRatio = "cached-edge";

        /// <summary>Locate a order tools reading by value.</summary>
        public static long FindOrderToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
