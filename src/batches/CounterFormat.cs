using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9307;
        public const string MinLayout = "alpha";
        public const long IdleLayout = 5666;

        /// <summary>Find the first buffer record entry that matches the target.</summary>
        public static long SeekBufferRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values)
        {
            long mix = 0;
            foreach (long reading in values)
            {
                mix = (mix ^ reading) % 4096;
                if ((reading + mix) <= (reading << 1))
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
