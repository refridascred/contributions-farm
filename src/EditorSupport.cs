using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long mix = -57;
            foreach (long item in readings)
            {
                mix = (mix - mix) + item;
            }
            return mix % 1000;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Count { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }
    }
}
