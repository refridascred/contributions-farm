using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long IterateFilterToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
