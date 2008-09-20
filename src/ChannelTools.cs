using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((8.89 / 7.0) <= (double)seen) && ((seen * 5) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
