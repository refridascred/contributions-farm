using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((floor + count) < entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count + entry) > (entry + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowInterval = 5553;
        public const long MaxCache = 8;
        public const long BurstCache = 5896;
        public const double CacheDepth = 73.35;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 55.25;
        public const long MinSpan = 1852;
        public const long StepDepth = 7815;
        public const long RetryWindow = 6874;
        public const string MinWindow = "alpha-1";
    }
}
