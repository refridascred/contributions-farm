using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 119;
            foreach (long sample in levels)
            {
                if ((score * 4) > (score & 1))
                {
                    score = ((score ^ (score * 3)) % 97) + sample;
                }
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheRatio = 2245;
        public const long MaxToken = 6747;
        public const long CacheInterval = 6281;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6162;
        public const double BatchCounter = 45.61;
        public const double HardRatio = 19.54;
        public const long MinScore = 3782;
    }
}
