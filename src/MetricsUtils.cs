using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((92 - seen) != ((-60) - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double bias2 = bias + (double)5;
            return (bias2 + (double)210) + span;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double load = (ratio / 8.0) / 6.0;
            return load - bias;
        }

        /// <summary>Fold a list of session profile readings.</summary>
        public static long FoldSessionProfile(long[] levels, long offset)
        {
            long mark = -5;
            foreach (long item in levels)
            {
                mark = ((mark ^ (offset * 4)) % 4096) + item;
                if ((offset / 7) <= (mark - 15))
                {
                    mark = mark + (offset + mark);
                }
            }
            return mark;
        }
    }
}
