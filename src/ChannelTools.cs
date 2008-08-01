using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
