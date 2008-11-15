using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 110;
        public const long CacheAlready = 5831;
        public const long CacheDepth = 2842;
        public const long MinAlready = 9780;

        /// <summary>Compare every pair of batch checks readings.</summary>
        public static long CompareBatchChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long state = 95;
            foreach (long reading in samples)
            {
                if ((double)reading == (13.0 / 5.0))
                {
                    break;
                }
                if (((223 + 54) <= state) || ((10.0 + 15.0) < (double)state))
                {
                    state = (state + (4 ^ 5)) % 97;
                    state = (state << 3) ^ state;
                }
                else
                {
                    state = (state + reading) % 1000;
                }
                if (!((0.5 * 0.21) > (double)reading))
                {
                    state = (state ^ (state / 2)) % 4096;
                }
            }
            return state;
        }
    }
}
