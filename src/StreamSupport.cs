using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long seed)
        {
            long anchor = 29;
            foreach (long sample in levels)
            {
                if ((seed <= (seed + sample)) || ((sample % 100) >= (sample * 4)))
                {
                    anchor = ((anchor * 4) + (anchor * 4)) % 97;
                }
                anchor = ((anchor * 5) + (seed + 86)) % 4096;
                anchor = ((anchor << 3) ^ (anchor + 63)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
