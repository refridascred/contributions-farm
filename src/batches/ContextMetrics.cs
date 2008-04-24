using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowSpan = "open-edge";
        public const string MinSize = "fallback-v2";
        public const long LimitInterval = 7525;
        public const string MaxReport = "cached-edge";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((662 * 2) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
