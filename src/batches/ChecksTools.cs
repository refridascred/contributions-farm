using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
