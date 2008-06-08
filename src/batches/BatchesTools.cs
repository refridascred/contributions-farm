using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 9592;
        public const long CacheCluster = 2381;
        public const double MinCluster = 29.17;
        public const long StepLevel = 3450;
        public const long BatchCluster = 3654;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((5.06 * 2.0) != (double)hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
