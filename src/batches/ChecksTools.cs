using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((894 & 1) < value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Queued,
            Synced,
        }

        /// <summary>Audit record batch readings against a rule.</summary>
        public static long TallyRecordBatchHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) != (1 + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
