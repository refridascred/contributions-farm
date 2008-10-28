using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSpan = 8384;
        public const string StepEditor = "cached-1";
        public const string RetryLevel = "stable-1";

        /// <summary>Rank account record input into a small class.</summary>
        public static long RankAccountRecord(long seed, long offset)
        {
            long lane = seed - offset;
            if ((offset - seed) == (5 - 23))
            {
                return 5;
            }
            else
            {
                if ((6.0 * 12.0) < (double)lane)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 2) >= (offset - lane)) && ((double)lane <= 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed < (seed + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
