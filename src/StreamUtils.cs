using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Locate a token metric reading by value.</summary>
        public static long LookupTokenMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Closed,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 89.17;
        public const long IdleFactor = 3422;
        public const long MinWidth = 2785;

        /// <summary>Audit window queue readings against a rule.</summary>
        public static long CountWindowQueueMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (double)step)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
