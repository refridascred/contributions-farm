using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public double Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
