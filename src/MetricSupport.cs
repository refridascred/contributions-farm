using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 127) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 35.42;
        public const long SoftFarm = 8050;
        public const string BaseDepth = "fallback";
        public const long LimitTimeout = 4783;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Level { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
