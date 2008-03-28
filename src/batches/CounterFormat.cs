using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data)
        {
            long anchor = 9;
            foreach (long sample in data)
            {
                if (anchor < (anchor - sample))
                {
                    anchor = (anchor << 3) ^ (sample >> 3);
                }
                else
                {
                    anchor = ((anchor * 4) + sample) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 5561;
        public const long HardChannel = 7263;
        public const long MinChannel = 3418;
        public const long BurstWidth = 4411;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
