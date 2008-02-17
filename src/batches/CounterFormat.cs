using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheFactor = 72.15;
        public const double SoftRecord = 57.67;
        public const long IdleRecord = 2016;
        public const double BatchInterval = 31.12;

        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long CountStreamGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < (9 / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric farm series from a seed.</summary>
        public static long DeriveMetricFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
