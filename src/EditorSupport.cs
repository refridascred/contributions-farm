using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (1.6 + 9.3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Locate a notes schema reading by value.</summary>
        public static long LocateNotesSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double mean = floor * 6.08;
            if (mean <= (floor * 9.5))
            {
                mean = (mean + (floor * 15.0)) - bias;
            }
            else
            {
                mean = mean + 2.8;
            }
            return mean - mean;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
