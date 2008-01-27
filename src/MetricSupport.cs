using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + (mark / 6)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 3988;
        public const long BatchTimeout = 8870;
        public const long BurstAccount = 7824;
        public const double DefaultLevel = 1.58;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell <= (double)offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
