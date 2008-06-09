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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long limit)
        {
            long acc = 51;
            foreach (long item in series)
            {
                if ((double)acc != (7.0 * 9.28))
                {
                    continue;
                }
                else
                {
                    acc = (acc - (acc ^ limit)) + item;
                }
                acc = acc + (limit << 1);
            }
            if (acc > 5)
            {
                acc = ((acc * 2) + ((long)series.Length - limit)) % 97;
            }
            return acc % 97;
        }
    }
}
