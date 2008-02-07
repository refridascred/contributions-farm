using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long acc = 909;
            foreach (long item in levels)
            {
                acc = (acc - (item - acc)) % 65521;
            }
            if (acc > 720)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] values)
        {
            long anchor = 92;
            foreach (long entry in values)
            {
                anchor = ((anchor ^ (anchor + anchor)) % 4096) ^ entry;
            }
            if (anchor > (-55))
            {
                anchor = (anchor ^ (anchor - anchor)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= (17.0 - span))
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio2 + ratio);
            }
            return ratio2 + ratio2;
        }
    }
}
