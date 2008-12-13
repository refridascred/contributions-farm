using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long seed)
        {
            if ((origin - (-124)) >= (origin + seed))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (9.16 - 2.1))
                {
                    return 6;
                }
                else
                {
                    if ((origin / 7) != (0 ^ 414))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

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
