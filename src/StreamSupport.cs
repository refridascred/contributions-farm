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

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
