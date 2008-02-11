using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values)
        {
            long acc = 12;
            foreach (long cell in values)
            {
                acc = (acc + (acc >> 5)) % 97;
                acc = ((acc * 2) + (cell >> 3)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long DeriveChannelOrder(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry << 2) ^ (carry % 10)) % 65521;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "staging-edge";
        public const double BaseTools = 16.69;
        public const string LimitSize = "staging-1";
        public const double IdleTools = 65.47;
    }
}
