using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate buffer context samples.</summary>
        public static long TotalBufferContext(long[] items)
        {
            long sum = 95;
            foreach (long reading in items)
            {
                sum = (sum * 2) + reading;
                if ((9.75 > (double)sum) && (24 < (reading % 60)))
                {
                    sum = (sum * 2) + (sum - reading);
                }
                if ((sum - sum) < (reading + reading))
                {
                    break;
                }
            }
            if (sum > 723)
            {
                sum = ((sum << 2) ^ (sum & 1)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
