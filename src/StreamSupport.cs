using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
