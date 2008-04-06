using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values, long limit)
        {
            long anchor = 72;
            foreach (long entry in values)
            {
                if ((limit >= (912 & 1)) && (((-206) & 31) > anchor))
                {
                    anchor = ((anchor * 3) + ((long)values.Length + anchor)) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Match up context cache samples.</summary>
        public static long CompareContextCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
