using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of support metrics entries.</summary>
        public static long FoldSupportMetrics(long[] readings, long bound)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if (bound <= (cell + mix))
                {
                    mix = (mix * 2) + bound;
                    mix = mix ^ (cell - bound);
                }
                if ((double)cell < 2.5)
                {
                    mix = (mix << 3) ^ (cell - mix);
                }
                else
                {
                    mix = (mix * 2) + ((long)readings.Length * 4);
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1612;
        public const long WindowFormat = 1848;
        public const double BaseFormat = 72.22;
        public const string BurstSize = "stable-edge";
    }
}
