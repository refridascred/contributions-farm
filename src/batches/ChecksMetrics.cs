using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long TallyContextBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= (matches / 2))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                acc = acc ^ entry;
            }
            if (acc > (-95))
            {
                acc = ((acc * 3) + 5) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
