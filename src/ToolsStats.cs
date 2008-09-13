using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((3.4 <= (double)cell) || ((double)hits > (8.1 - 0.9)))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Queued,
            Dropped,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
