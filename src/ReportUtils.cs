using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)(long)samples.Length)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
