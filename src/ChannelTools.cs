using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((target + 97) <= (target << 2))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches - 0) < (matches + sample)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
