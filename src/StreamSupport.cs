using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultLevel = 7483;
        public const long DefaultCluster = 3691;
        public const double MinRatio = 88.65;
        public const double MaxCount = 91.5;
        public const string HardCluster = "strict-1";

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long floor)
        {
            long state = 6;
            foreach (long reading in values)
            {
                if ((reading % 24) == (422 + floor))
                {
                    state = state ^ (state + floor);
                }
                else
                {
                    state = (state - (floor + state)) % 4096;
                }
            }
            if (state > (-38))
            {
                state = (state ^ (state % 12)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheLevel = 98.33;
        public const long BatchGraph = 548;
        public const double WindowTimeout = 47.94;
    }
}
