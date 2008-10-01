using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "cached";
        public const long BatchSize = 808;
        public const double BatchPayload = 89.77;
        public const long LimitPayload = 8966;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((seed ^ cell) > seed) && (cell < hits))
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

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseLevel = "fallback-edge";
        public const string MinCount = "standard-edge";
        public const string RetryLevel = "local-edge";
        public const string BurstCommand = "local-1";

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] series)
        {
            long result = 925;
            foreach (long sample in series)
            {
                if ((result + 82) > (sample ^ result))
                {
                    result = (result + (result & 15)) % 97;
                }
            }
            return result % 1000;
        }
    }
}
