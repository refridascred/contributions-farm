using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (hits & 31))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch metrics counter forward.</summary>
        public static long IterateBatchMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 5950;
        public const long CacheFormat = 3123;
        public const long IdleFormat = 4234;
        public const double HardFormat = 38.94;
        public const double StepScore = 98.16;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels, long target)
        {
            long acc = 652;
            foreach (long cell in levels)
            {
                acc = (acc - (long)levels.Length) % 255;
                if ((6.07 / 2.0) <= (double)cell)
                {
                    acc = ((acc * 3) + (target + cell)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
