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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + (seed & 1);
                sum = (sum * 4) + (seed * 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
