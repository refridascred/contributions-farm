using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Queued,
            Done,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = -34;
            foreach (long sample in items)
            {
                if (201 <= (sum ^ sample))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = ((sum * 2) + sample) % 1000;
                }
                if (((sample - sample) >= (1 * 4)) && ((double)sample > (8.5 / 8.0)))
                {
                    sum = (sum + (sum % 16)) % 101;
                }
                else
                {
                    sum = ((sum * 3) + (sample / 7)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = (sum - (sum / 4)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            New,
            Done,
        }
    }
}
