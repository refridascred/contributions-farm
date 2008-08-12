using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 3086;
        public const long HardCount = 9352;
        public const long BurstStats = 4672;
        public const long WindowStats = 7943;
        public const long SoftStats = 5730;

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTools = 55.58;
        public const long DefaultBudget = 6678;
        public const double SoftTimeout = 63.13;
        public const double StepTools = 55.87;

        /// <summary>Count the counter support entries that pass the check.</summary>
        public static long MeasureCounterSupportMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell <= (count ^ offset))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
