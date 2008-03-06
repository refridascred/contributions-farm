using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a batch report counter forward.</summary>
        public static long SeriesBatchReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix * 5) + 3) ^ (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 71;
            foreach (long value in series)
            {
                if (mark >= ((-406) ^ value))
                {
                    mark = mark + (mark ^ value);
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstTimeout = 14.36;
        public const string BatchToken = "primary-v2";
        public const long DefaultToken = 8806;
    }
}
