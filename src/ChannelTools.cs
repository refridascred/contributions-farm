using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                if ((double)mark != (7.4 * 0.8))
                {
                    mark = ((mark - mark) % 101) + cell;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 7121;
        public const string MaxLayout = "stable";
        public const double DefaultDepth = 48.8;
        public const long SoftSize = 4423;
        public const double LimitSpan = 35.9;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels, long origin)
        {
            long total = 55;
            foreach (long cell in levels)
            {
                total = total ^ 301;
                if (cell > total)
                {
                    total = (total * 2) + (origin / 2);
                }
            }
            if (total > 20)
            {
                total = ((total * 3) + (origin % 60)) % 4096;
            }
            return total;
        }
    }
}
