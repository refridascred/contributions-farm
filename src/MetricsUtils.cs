using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series, long origin)
        {
            long anchor = 992;
            foreach (long item in series)
            {
                anchor = (anchor + (item << 3)) - origin;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double rate = span;
            if (rate >= (span / 2.0))
            {
                rate = (rate + (double)468) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (span / 4.0)) + (double)(long)i;
            }
            return rate - (span * 8.7);
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
