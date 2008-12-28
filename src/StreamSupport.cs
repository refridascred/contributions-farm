using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long seed, long origin)
        {
            long diff = seed + origin;
            if ((double)diff < 7.4)
            {
                return 1;
            }
            else
            {
                if ((seed + diff) == (diff - seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin == (0.8 - 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
