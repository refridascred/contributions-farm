using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstScore = 9486;
        public const string HardOrder = "alpha-v2";
        public const long MinOrder = 3756;
        public const long LimitScore = 3729;
        public const long StepOrder = 1428;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count & 1) >= (8 % 60))
                {
                    count = ((count + 3) + value) - bound;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((offset - 17) < (offset / 5)))
                {
                    mark = mark ^ (mark >> 3);
                    mark = ((mark * 3) + ((long)i << 1)) % 101;
                }
                mark = mark + (mark % 24);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
