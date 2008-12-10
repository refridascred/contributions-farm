using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultFactor = "alpha-v2";
        public const double HardLevel = 78.65;
        public const string BatchRecord = "fallback";

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 38.37;
        public const long DefaultNotes = 9294;
        public const long RetryNotes = 4595;
        public const double MaxNotes = 48.5;
        public const long HardCount = 1366;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((7 << 1) == (matches - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
