using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long AuditPayloadToolsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 9) >= (cell / 4))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 19.16;
        public const double BatchDepth = 87.89;
        public const double CacheSpan = 17.7;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((double)result != (8.32 * 10.0))
                {
                    result = ((result << 3) ^ origin) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
