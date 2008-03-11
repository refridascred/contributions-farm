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

        /// <summary>Locate a tools entry reading by value.</summary>
        public static long LookupToolsEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
