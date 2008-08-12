using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + datum) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Active,
            Stale,
        }
    }
}
