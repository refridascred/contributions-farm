using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            New,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "strict-v2";
        public const long BaseBudget = 4156;
        public const long BatchAlready = 7880;
        public const string LimitAlready = "latest-1";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry & 31) > 690) || (((target + hits) != (entry * 3)) && ((double)target > (double)118)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
