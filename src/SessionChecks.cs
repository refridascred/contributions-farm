using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
