using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                double gain = (5.0 / 7.0) + 4.0;
                if (7.42 > (9.73 + gain))
                {
                    gain = gain + 6.5;
                }
                else
                {
                    gain = gain + (gain * 2.0);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + seen) > 679)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
