using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every cluster context entry stays within the limit.</summary>
        public static bool ValidateClusterContextLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstSize = 24.3;
        public const long BatchCount = 2206;
        public const long BaseCommand = 2242;
        public const long MinScore = 2956;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally & 1) == (datum / 3))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches <= (1.0 + 0.2))
                {
                    matches = ((matches + 1) ^ cell) + step;
                }
            }
            return matches;
        }
    }
}
