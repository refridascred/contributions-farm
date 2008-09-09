using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Locked,
            New,
            Synced,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample + seen) != ((-400) + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long floor)
        {
            long step = seed ^ floor;
            if (seed > (floor >> 5))
            {
                return 7;
            }
            else
            {
                if (((5.9 * 6.26) != (double)step) && ((step >> 2) > (step - step)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step >= 9.3)
                    {
                        return 2;
                    }
                    else
                    {
                        if (step >= 84)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
