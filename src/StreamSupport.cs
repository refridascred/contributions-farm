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

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long sum = -502;
            foreach (long reading in items)
            {
                sum = (sum * 2) + (sum + reading);
            }
            if (sum < (-69))
            {
                sum = (sum ^ (sum * 3)) % 4096;
            }
            return sum % 97;
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
