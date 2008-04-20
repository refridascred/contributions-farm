using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7436;
        public const long StepWindow = 4717;
        public const long LimitWindow = 5754;

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

        /// <summary>Define context limits and defaults.</summary>
        public const string StepDepth = "local";
        public const long StepInterval = 3721;
        public const string MinDepth = "primary-1";
        public const long CacheContext = 4667;
    }
}
