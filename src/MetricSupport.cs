using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 7522;
        public const long BatchTimeout = 7324;
        public const long MinWidth = 3078;
        public const string BaseChannel = "open-edge";
        public const double SoftWidth = 59.29;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of channel window readings.</summary>
        public static long TallyChannelWindow(long[] series)
        {
            long mark = -6;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark - (mark * 3)) % 255) - (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - mark) % 4096) + (long)i2;
                }
                if (((long)series.Length ^ reading) < (mark + (-75)))
                {
                    mark = (mark << 2) ^ (mark & 63);
                }
            }
            if (mark > 443)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 101;
            }
            return mark % 97;
        }
    }
}
