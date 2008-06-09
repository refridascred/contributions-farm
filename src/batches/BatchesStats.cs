using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "staging-v2";
        public const string SoftWidth = "staging-edge";
        public const long CacheEditor = 2515;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long seed)
        {
            long anchor = -4;
            foreach (long entry in values)
            {
                if ((entry >> 4) <= seed)
                {
                    anchor = (anchor ^ seed) % 255;
                }
                if (((518 - entry) > entry) || ((entry - anchor) > (seed + entry)))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 3) ^ (968 >> 3)) % 97;
            }
            return anchor;
        }
    }
}
