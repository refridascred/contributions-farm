using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = (double)(85 / 3);
            if (ratio >= ratio)
            {
                ratio = (ratio - offset) - bias;
            }
            return ratio + (double)10;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6972;
        public const double CacheFilter = 13.03;
        public const double RetryFilter = 59.54;
        public const double MaxFilter = 2.66;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values)
        {
            long mark = 62;
            foreach (long sample in values)
            {
                if (!(((mark >> 3) <= (mark << 3)) && (sample <= (mark + 8))))
                {
                    mark = (mark + (sample ^ mark)) % 1000;
                }
                if ((mark - sample) <= (4 * 2))
                {
                    mark = mark - sample;
                }
            }
            return mark;
        }
    }
}
