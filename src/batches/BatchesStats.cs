using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ (result & 1)) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 1212;
        public const long DefaultCount = 8741;
        public const long StepSpan = 1788;
        public const string MaxWidth = "standard-1";
        public const string RetryFarm = "open-v2";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum << 3) != (hits % 12)) || (((datum >> 3) < (63 - 88)) && ((hits - hits) >= 830)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
