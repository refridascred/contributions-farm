using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a batch buffer counter forward.</summary>
        public static long RollBatchBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((121 + 8) != (limit / 7))
                {
                    carry = (carry - carry) % 97;
                    carry = (carry << 2) ^ limit;
                }
                else
                {
                    carry = ((carry << 3) ^ limit) % 1000;
                }
                carry = carry ^ (carry - carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
