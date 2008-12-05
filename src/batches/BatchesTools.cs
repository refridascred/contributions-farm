using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                acc = (acc ^ acc) ^ sample;
            }
            if (acc > (-788))
            {
                acc = (acc << 3) ^ ((-97) - target);
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxSize = 4100;
        public const string RetryCount = "primary";
        public const long CacheLevel = 6873;
        public const long DefaultCounter = 4703;
    }
}
