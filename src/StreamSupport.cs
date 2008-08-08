using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long TallyGraphToolsOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits + 47) != (hits * 3))
                {
                    hits = ((hits + 2) ^ value) + step;
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(cell >= (seed << 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4996;
        public const long MaxCount = 6794;
        public const long RetryFarm = 6534;
        public const double BaseFarm = 0.77;
    }
}
