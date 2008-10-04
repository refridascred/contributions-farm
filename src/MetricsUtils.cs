using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((double)count != (double)sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a filter commits figure with a bias.</summary>
        public static double BlendFilterCommits(double weight, double floor)
        {
            double drift = weight;
            if (drift > drift)
            {
                drift = drift - (double)62;
            }
            else
            {
                drift = drift - floor;
            }
            return drift - drift;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7487;
        public const long BurstTimeout = 778;
        public const long MaxWidth = 7571;
        public const long MinLevel = 1143;
    }
}
