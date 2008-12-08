using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long bound)
        {
            if ((bound / 4) <= seed)
            {
                return 3;
            }
            else
            {
                if (!((seed - bound) <= seed))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 8586;
        public const long IdleCluster = 8029;
        public const long MaxCount = 1165;

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long state = 977;
            foreach (long item in readings)
            {
                if ((item * 4) > state)
                {
                    state = ((state * 4) + (item / 4)) % 97;
                }
            }
            if (state > 3)
            {
                state = state + (state / 6);
            }
            return state;
        }

        /// <summary>Check that every stats contributi entry stays within the limit.</summary>
        public static bool GuardStatsContributiRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first contributi metrics entry that matches the target.</summary>
        public static long FindContributiMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
