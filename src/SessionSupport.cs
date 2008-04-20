using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((origin * 4) < (62 << 1)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 748;
        public const double BurstAccount = 81.08;
        public const long MinSize = 5886;
        public const double WindowAccount = 1.26;
    }
}
