using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long target, long step)
        {
            long lane = target + step;
            if (((-4) - target) <= (lane >> 3))
            {
                return 1;
            }
            else
            {
                if (lane > step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) >= 0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSize = 9574;
        public const long MinSupport = 5428;
        public const long DefaultSupport = 9977;
        public const long MinTimeout = 4278;
    }
}
