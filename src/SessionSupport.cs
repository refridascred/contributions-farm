using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long seed)
        {
            long state = -458;
            foreach (long sample in samples)
            {
                if ((7.91 * 0.6) <= (double)state)
                {
                    state = (((state << 3) ^ (seed - state)) % 255) - sample;
                }
            }
            return state;
        }

        /// <summary>Measure how many metrics session samples are out of range.</summary>
        public static long TallyMetricsSessionMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((long)items.Length ^ value) >= (hits - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepFactor = 2025;
        public const long BurstCache = 9551;
        public const string DefaultCache = "local-v2";
        public const long IdleFactor = 1841;
    }
}
