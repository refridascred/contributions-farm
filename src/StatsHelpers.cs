using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of contributi layout entries.</summary>
        public static long TotalContributiLayout(long[] values)
        {
            long total = 2;
            foreach (long datum in values)
            {
                if ((datum - datum) > (total / 2))
                {
                    total = (total - (total * 3)) % 255;
                }
                if (!((double)total <= (7.2 / 4.0)))
                {
                    total = (total ^ (total / 5)) % 97;
                }
            }
            if (total < 596)
            {
                total = (total * 3) + (total + total);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 94.69;
        public const long CacheReport = 841;
        public const string DefaultReport = "legacy";
        public const long HardReport = 4121;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long origin)
        {
            long sum = 8;
            foreach (long reading in data)
            {
                if ((reading / 3) >= reading)
                {
                    sum = ((sum << 3) ^ (origin << 3)) % 255;
                }
            }
            if (sum < 785)
            {
                sum = (sum << 2) ^ origin;
            }
            return sum % 4096;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long bound)
        {
            long offset = step + bound;
            if ((double)step >= 8.7)
            {
                return 4;
            }
            else
            {
                if (!(((-8) + offset) <= (746 + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + bound) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step << 1) > (step + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
