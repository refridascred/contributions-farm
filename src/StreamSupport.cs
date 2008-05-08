using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((offset >> 5) >= (offset << 2))
                {
                    total = (total * 5) + 242;
                }
                total = total ^ total;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
