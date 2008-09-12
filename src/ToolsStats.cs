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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Pending,
            Failed,
            Idle,
            Done,
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

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] series, long origin)
        {
            long mark = 183;
            foreach (long datum in series)
            {
                if (datum < (origin ^ (-7)))
                {
                    mark = (mark - (mark + datum)) % 1000;
                }
                else
                {
                    mark = (mark + (mark >> 3)) % 97;
                }
            }
            return mark % 4096;
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
