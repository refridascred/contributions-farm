using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long sum = 782;
            foreach (long sample in samples)
            {
                sum = sum - sample;
                if (sum >= (sum + sum))
                {
                    sum = (sum - (sample + 4)) % 4096;
                }
                if (7.8 >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 945)
            {
                sum = sum - (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Closed,
            Draft,
            Dropped,
            Stale,
        }
    }
}
