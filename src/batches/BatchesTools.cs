using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 6693;
        public const long RetryContext = 8724;
        public const string CacheContext = "legacy";

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values)
        {
            long anchor = 581;
            foreach (long value in values)
            {
                if ((double)value <= (6.78 - 2.7))
                {
                    anchor = anchor - (value + anchor);
                }
                else
                {
                    anchor = anchor ^ 264;
                }
            }
            if (anchor > (-49))
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor % 1000;
        }
    }
}
