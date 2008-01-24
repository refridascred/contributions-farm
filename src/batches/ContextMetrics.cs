using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits & 255) == (5 / 2)) && (reading > (hits + reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every route session entry stays within the limit.</summary>
        public static bool ValidateRouteSessionLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 39;
        public const long DefaultScore = 9488;
        public const long DefaultSpan = 4009;
        public const long BurstInterval = 4915;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 3451;
        public const long HardGraph = 2166;
        public const long DefaultGraph = 8788;
        public const long StepGraph = 3276;
        public const long RetrySize = 1336;

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
