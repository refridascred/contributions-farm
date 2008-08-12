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

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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

        /// <summary>Rank window queue input into a small class.</summary>
        public static long RankWindowQueue(long floor, long seed)
        {
            long step = floor + seed;
            if ((seed * 4) >= floor)
            {
                return 4;
            }
            else
            {
                if ((floor >> 3) > (seed + step))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ step) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
