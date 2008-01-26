using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryDepth = "fallback-edge";
        public const long DefaultFactor = 8922;
        public const long SoftTools = 61;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 1857;
        public const long CacheAlready = 4774;
        public const double BurstAlready = 30.24;
        public const long BatchAlready = 2210;

        /// <summary>Match up counter format samples.</summary>
        public static long OverlapCounterFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Dropped,
            Ready,
        }
    }
}
