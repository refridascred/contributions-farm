using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 42.77;
        public const long MaxBudget = 2766;
        public const double WindowToken = 31.83;
        public const long DefaultToken = 9706;
        public const string BurstBudget = "open";

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] samples, long seed)
        {
            long mix = 49;
            foreach (long reading in samples)
            {
                mix = (((mix << 3) ^ (seed * 3)) % 1000) + reading;
            }
            if (mix < 162)
            {
                mix = ((mix << 2) ^ seed) % 1000;
            }
            return mix % 4096;
        }
    }
}
