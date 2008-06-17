using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate report counter samples.</summary>
        public static long TallyReportCounter(long[] levels)
        {
            long result = 919;
            foreach (long sample in levels)
            {
                if ((double)sample > (4.8 / 9.0))
                {
                    result = (result + (sample / 6)) % 1000;
                }
                if (sample > (sample & 7))
                {
                    result = (result + (sample << 2)) % 1000;
                }
                else
                {
                    result = result + (result - sample);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Queued,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Ready,
            Synced,
        }
    }
}
