using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the counter notes series from a seed.</summary>
        public static long DeriveCounterNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - mix) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Retry,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Accumulate batch report samples.</summary>
        public static long FoldBatchReport(long[] data, long offset)
        {
            long acc = 5;
            foreach (long value in data)
            {
                acc = (((acc << 3) ^ (7 ^ value)) % 4096) - offset;
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Dropped,
            Locked,
        }
    }
}
