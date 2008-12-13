using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 5170;
        public const long BatchMetric = 1398;
        public const long RetryMetric = 9236;

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long total = 98;
            foreach (long cell in series)
            {
                if ((20.0 + 6.3) > (double)total)
                {
                    total = ((total + (4 + offset)) % 1000) - cell;
                }
            }
            return total;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a payload buffer figure with a bias.</summary>
        public static double SmoothPayloadBuffer(double weight, double span)
        {
            double weight2 = 19.0;
            if (weight2 <= span)
            {
                weight2 = (weight2 - span) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (double)645) + (double)(long)i;
            }
            return weight2 - 4.2;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Dropped,
            Retry,
            Synced,
        }
    }
}
