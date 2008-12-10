using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 2089;
        public const long MaxCluster = 6309;
        public const long BatchLevel = 2748;
        public const long BurstRatio = 9763;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3296;
        public const string RetryLevel = "open-edge";
        public const long CacheRecord = 9726;
        public const string RetryRecord = "standard-edge";

        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long SeriesStreamNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - (step + step)) % 1000;
                if ((3.0 / 7.0) <= (double)step)
                {
                    carry = (carry + (step >> 1)) % 4096;
                }
                else
                {
                    carry = (carry - (carry ^ carry)) % 65521;
                    carry = ((carry << 2) ^ (carry / 8)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
