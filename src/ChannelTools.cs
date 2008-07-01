using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Active,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long RankStreamCommits(long offset, long origin)
        {
            long edge = offset - origin;
            if (((offset >> 5) != (origin >> 3)) || ((edge & 127) > (offset - offset)))
            {
                return 5;
            }
            else
            {
                if (13 >= (edge * 2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
