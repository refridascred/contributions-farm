using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((774 ^ seed) < (long)series.Length)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
