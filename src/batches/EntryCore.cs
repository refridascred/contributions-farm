using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long MeasureCounterClusterGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((2.0 * 15.0) >= (double)value))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Stale,
            Failed,
            Queued,
        }
    }
}
