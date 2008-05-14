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

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
