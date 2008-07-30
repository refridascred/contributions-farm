using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data, long offset)
        {
            long state = 3;
            foreach (long sample in data)
            {
                if (7 >= (state - sample))
                {
                    state = (state - (offset - offset)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (offset % 60)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long origin)
        {
            long mark = 899;
            foreach (long cell in values)
            {
                if ((double)origin < 2.0)
                {
                    mark = mark ^ cell;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
