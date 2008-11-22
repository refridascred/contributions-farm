using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples, long target)
        {
            long carry = 28;
            foreach (long sample in samples)
            {
                carry = ((carry - (sample - carry)) % 255) + target;
            }
            return carry;
        }
    }
}
