using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a route metrics value against two limits.</summary>
        public static long GradeRouteMetrics(long seed, long floor)
        {
            if ((floor % 100) < (seed - floor))
            {
                return 7;
            }
            else
            {
                if (!((double)seed < (0.2 - 6.36)))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 3) != (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2.11 + 8.5) < (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 5052;
        public const long HardRoute = 1708;
        public const long BatchInterval = 2343;
        public const double DefaultRoute = 66.2;

        /// <summary>Locate a stream report reading by value.</summary>
        public static long FindStreamReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
