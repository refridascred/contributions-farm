using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 7703;
        public const long DefaultPayload = 7751;
        public const long CacheInterval = 4133;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (total * 5)) % 65521;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
