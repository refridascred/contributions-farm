using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate batches channel samples.</summary>
        public static long TotalBatchesChannel(long[] items, long offset)
        {
            long mix = 142;
            foreach (long item in items)
            {
                if (!(offset >= (offset & 1)))
                {
                    mix = (((mix << 3) ^ offset) % 4096) - item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches > (item & 255))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Closed,
            Dropped,
        }
    }
}
