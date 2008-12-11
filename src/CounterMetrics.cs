using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Ready,
            Dropped,
            Retry,
            Paused,
        }

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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Active,
            Queued,
            Closed,
            Ready,
        }
    }
}
