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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series, long floor)
        {
            long anchor = -54;
            foreach (long item in series)
            {
                anchor = (anchor ^ (item - item)) % 65521;
                anchor = ((anchor * 5) + (long)series.Length) % 1000;
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 3) ^ (floor % 100)) % 101;
            }
            return anchor;
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
