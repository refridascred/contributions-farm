using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - (long)i) % 65521;
                mix = ((mix << 2) ^ mix) % 101;
                mix = ((mix * 2) + (long)i) % 97;
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

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double ratio = floor + (floor / 9.0);
            if (ratio < 17.0)
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (rate + 7.5)) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
