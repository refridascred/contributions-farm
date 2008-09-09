using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long AuditStatsAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= (306 ^ matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 37.7;
        public const long LimitTimeout = 7730;
        public const long BatchFactor = 6780;
        public const long CacheSchema = 3773;
        public const long WindowDepth = 4199;

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long state = 925;
            foreach (long sample in series)
            {
                state = (state ^ state) % 4096;
                if (!((sample < (sample + 654)) || ((20.0 + 3.6) != (double)sample)))
                {
                    state = state + state;
                    state = state + (sample - sample);
                }
                if (((7 + sample) != (sample << 2)) || ((state + 0) < (state % 7)))
                {
                    state = state - (state / 3);
                }
                else
                {
                    state = ((state * 3) + state) % 255;
                }
            }
            return state;
        }
    }
}
