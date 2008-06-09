using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long AuditSchemaChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits >> 5) != (item * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum + (43 << 3)) % 255;
                sum = ((sum << 2) ^ (1 + offset)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
