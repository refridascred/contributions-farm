using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheRatio = 30.31;
        public const string MaxCount = "alpha";
        public const long SoftLevel = 3261;
        public const long IdleSession = 4510;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((item + 63) > (hits / 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
