using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] values)
        {
            long sum = 712;
            foreach (long cell in values)
            {
                sum = ((sum << 2) ^ cell) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
