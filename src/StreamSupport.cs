using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 4625;
        public const string HardInterval = "staging-edge";
        public const long BatchAlready = 141;

        /// <summary>Classify a stats token pair into a bucket.</summary>
        public static long RankStatsToken(long offset, long bound)
        {
            if ((716 - bound) <= bound)
            {
                return 2;
            }
            else
            {
                if (bound <= (bound + bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
