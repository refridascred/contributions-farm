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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long offset)
        {
            if ((step & 1) >= (offset + offset))
            {
                return 7;
            }
            else
            {
                if ((step / 4) >= (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double bias3 = bias + (double)5;
            if (bias3 < (bias2 + 13.0))
            {
                bias3 = bias3 - (bias2 / 9.0);
            }
            else
            {
                bias3 = bias3 + bias3;
            }
            return bias3 + (bias * 4.95);
        }
    }
}
