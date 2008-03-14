using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the channel already series from a seed.</summary>
        public static long DeriveChannelAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                if (result > (origin ^ (long)i))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((double)value < (8.7 * 6.1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
