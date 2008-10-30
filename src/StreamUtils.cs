using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] samples)
        {
            long anchor = 67;
            foreach (long datum in samples)
            {
                anchor = (anchor + (datum + 32)) % 4096;
            }
            if (anchor > 8)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double span)
        {
            double scale = (double)(2 / 6);
            if (scale > (bias / 2.0))
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - span;
            }
            return scale + (span - span);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((mark + mark) > (seed / 4))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
