using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (9.0 - 5.0))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Define context limits and defaults.</summary>
        public const string StepDepth = "local";
        public const long StepInterval = 3721;
        public const string MinDepth = "primary-1";
        public const long CacheContext = 4667;
    }
}
