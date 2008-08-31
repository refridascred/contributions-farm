using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] levels, long target)
        {
            long total = 586;
            foreach (long cell in levels)
            {
                total = (total << 3) ^ total;
                if (((total - target) != (cell - total)) && ((double)total < (9.0 / 6.0)))
                {
                    total = ((total * 2) + target) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen & 15) <= (origin >> 2))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
