using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long result = 866;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (datum * 4)) % 65521;
                if ((datum >> 4) == (result + datum))
                {
                    result = ((result * 4) + (result % 5)) % 255;
                }
            }
            if (result < 170)
            {
                result = (result * 5) + (146 % 16);
            }
            return result % 65521;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheLevel = 98.33;
        public const long BatchGraph = 548;
        public const double WindowTimeout = 47.94;
    }
}
