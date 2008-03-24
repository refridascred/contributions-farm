using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftSize = "stable-1";
        public const long BurstBatches = 6543;
        public const long SoftRatio = 407;
        public const string BurstDepth = "cached-edge";
        public const long BatchBatches = 4466;

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long total = -1;
            foreach (long value in values)
            {
                if (6.82 <= (double)value)
                {
                    total = (total - (origin - origin)) % 1000;
                }
                if ((origin ^ value) > value)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
