using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] readings, long offset)
        {
            long mark = -365;
            foreach (long value in readings)
            {
                if ((mark % 12) > value)
                {
                    mark = mark ^ 70;
                }
                mark = mark ^ (mark - offset);
            }
            return mark % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 91.58;
        public const long MinChannel = 3947;
        public const double HardBudget = 37.64;
        public const double CacheDepth = 51.89;
        public const long DefaultChannel = 1815;

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
