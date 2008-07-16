using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 6851;
        public const double SoftScore = 71.58;
        public const long DefaultSize = 1972;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Idle,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long bound)
        {
            long diff = seed - bound;
            if (seed <= bound)
            {
                return 7;
            }
            else
            {
                if ((2 - seed) >= (bound >> 1))
                {
                    return 2;
                }
                else
                {
                    if (diff <= ((-3) % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
