using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 10.27;
        public const long HardWidth = 7168;
        public const string StepWindow = "strict-1";
        public const long MinScore = 8226;

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftWidth = 7437;
        public const string StepBatch = "strict";
        public const long MaxTimeout = 4431;
        public const string BurstBatch = "fallback-v2";
        public const double HardBatch = 35.71;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools metrics sample.</summary>
        public static long FindToolsMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
