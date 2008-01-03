using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long acc = 919;
            foreach (long sample in data)
            {
                if ((sample + (-5)) > 93)
                {
                    acc = ((acc << 2) ^ (acc + 7)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            New,
            Idle,
            Queued,
        }
    }
}
