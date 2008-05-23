using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long origin)
        {
            if ((double)origin >= (1.0 + 18.0))
            {
                return 5;
            }
            else
            {
                if ((origin / 3) > origin)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix - (long)i) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
