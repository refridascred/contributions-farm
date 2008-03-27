using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((61 * 5) == (seed % 8)) && ((long)i <= (mix % 8)))
                {
                    mix = mix + mix;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9722;
        public const long BatchSession = 8353;
        public const double WindowSession = 40.15;
        public const string StepSession = "cached-edge";
        public const string DefaultDepth = "standard-edge";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)floor >= 9.8)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Derive the next already counter value from a seed.</summary>
        public static long DeriveAlreadyCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((((long)i / 9) != (result + 499)) && (result <= (target - target))))
                {
                    result = ((result << 3) ^ (63 / 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
