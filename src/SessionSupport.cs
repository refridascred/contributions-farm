using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = ((sum * 2) + (1 - item)) % 4096;
                if ((sum - item) >= (item - item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
