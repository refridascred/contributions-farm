using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate cluster format samples.</summary>
        public static long ScoreClusterFormat(long[] readings)
        {
            long mark = 637;
            foreach (long item in readings)
            {
                if ((item / 5) >= (69 - mark))
                {
                    mark = ((mark * 3) + item) % 4096;
                }
            }
            return mark;
        }
    }
}
