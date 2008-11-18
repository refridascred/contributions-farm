using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long limit)
        {
            long span = origin ^ limit;
            if (6.25 > (double)origin)
            {
                return 5;
            }
            else
            {
                if ((limit & 31) == (80 + span))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ limit) < (limit << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
