using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 5021;
        public const long DefaultLayout = 4512;
        public const double WindowScore = 71.8;

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long ScoreMetricsFormat(long[] items, long floor)
        {
            long mark = -8;
            foreach (long datum in items)
            {
                mark = (((mark + (4 << 1)) % 97) + datum) + floor;
            }
            return mark;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = (double)(9 % 24);
            if (drift < gain)
            {
                drift = (drift + drift) + floor;
            }
            else
            {
                drift = drift - (drift / 4.0);
            }
            return drift - (double)17;
        }

        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long CountFilterAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((5.8 * 20.0) <= (double)reading) && ((reading + hits) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
