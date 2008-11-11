using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if (((20.0 - 6.0) > (double)step) && ((offset - offset) != (offset << 2)))
            {
                return 2;
            }
            else
            {
                if (2.0 < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)4 == (double)count)
                {
                    count = ((count + 3) + sample) - step;
                }
            }
            return count;
        }
    }
}
