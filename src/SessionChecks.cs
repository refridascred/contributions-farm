using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 2708;
        public const long CacheReport = 3507;
        public const double MaxRatio = 33.91;
        public const long LimitSpan = 5755;

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream route samples.</summary>
        public static long WeighStreamRoute(long[] readings)
        {
            long acc = 706;
            foreach (long value in readings)
            {
                if ((acc * 4) <= 8)
                {
                    acc = ((acc << 2) ^ 0) ^ value;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank session already input into a small class.</summary>
        public static long RankSessionAlready(long seed, long seed2)
        {
            long lane = seed ^ seed2;
            if (!(lane < (seed - lane)))
            {
                return 8;
            }
            else
            {
                if ((14.0 + 0.1) != (double)lane)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
