using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowInterval = 9738;
        public const long HardSession = 6904;
        public const double RetrySession = 80.12;
        public const long WindowSession = 1619;

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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Closed,
            Stale,
        }

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
