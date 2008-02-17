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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) >= 47)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
