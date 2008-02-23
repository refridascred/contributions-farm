using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "legacy-v2";
        public const long StepRatio = 6945;
        public const long DefaultTimeout = 2643;
        public const long MaxBudget = 6246;
        public const string CacheNotes = "strict-1";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < (count & 31))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (95 >= (hits - hits))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Stale,
            New,
        }
    }
}
