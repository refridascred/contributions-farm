using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 2563;
        public const long MinSize = 1441;
        public const string IdleInterval = "local";
        public const double SoftToken = 13.84;
        public const long CacheToken = 1248;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally < (tally - 8)) && ((offset + tally) > tally)) && (((3.78 + 8.61) < (double)tally) && ((0.5 * 7.24) >= (double)offset)))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            New,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
