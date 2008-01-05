using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long TallyClusterRecordGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((33 + reading) >= (seed % 10)) || ((seed ^ reading) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long sum = -8;
            foreach (long entry in items)
            {
                sum = ((sum - (entry ^ entry)) % 255) - origin;
                if ((entry >> 5) <= sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
