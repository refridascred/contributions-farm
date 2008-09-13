using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((4.26 * 3.0) >= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "standard-1";
        public const long DefaultAlready = 8671;
        public const double SoftCount = 2.17;
        public const long LimitDepth = 1139;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Closed,
            Done,
            Queued,
            Stale,
        }
    }
}
