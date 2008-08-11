using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 > (double)2)
            {
                ratio2 = ratio2 - (ratio2 - 7.4);
            }
            return ratio2 + ratio;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 2425;
        public const double MaxBudget = 87.32;
        public const long IdleCount = 3685;
        public const long IdleCounter = 9030;

        /// <summary>Roll a buffer metrics counter forward.</summary>
        public static long StepBufferMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((51 > ((long)readings.Length & 63)) && ((offset / 3) >= seen)) || ((datum + seen) <= (offset % 100)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
