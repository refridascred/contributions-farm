using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of command report entries.</summary>
        public static long TotalCommandReport(long[] samples, long origin)
        {
            long acc = 0;
            foreach (long cell in samples)
            {
                acc = (((acc << 2) ^ acc) + cell) + origin;
            }
            if (acc > 50)
            {
                acc = (acc + (3 - 96)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long DeriveMetricLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin << 1) >= (origin * 3))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
