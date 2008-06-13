using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Locked,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Size { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the stats command series from a seed.</summary>
        public static long SeriesStatsCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if (carry < (73 + carry))
                {
                    carry = (carry - (long)i) % 65521;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
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
