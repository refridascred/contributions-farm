using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Draft,
            Closed,
            Active,
            Done,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)(long)data.Length >= (double)item) || (((matches % 60) <= (item ^ 242)) || (45 >= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate commits channel readings against a bound.</summary>
        public static bool GuardCommitsChannelRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
