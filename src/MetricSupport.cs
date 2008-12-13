using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetrySize = 58.18;
        public const string MaxFilter = "alpha-1";
        public const long BaseFilter = 3369;
        public const string BurstFactor = "alpha-1";
        public const long HardFilter = 4042;

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series)
        {
            long acc = 559;
            foreach (long datum in series)
            {
                acc = ((acc << 3) ^ (datum - datum)) % 4096;
                acc = (acc - ((long)series.Length % 97)) % 1000;
                acc = acc + (732 + 340);
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5261;
        public const long StepReport = 1915;
        public const long IdleRatio = 1419;
    }
}
