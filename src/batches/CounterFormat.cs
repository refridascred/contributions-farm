using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank account support input into a small class.</summary>
        public static long RankAccountSupport(long seed, long seed2)
        {
            if ((624 / 3) >= seed2)
            {
                return 2;
            }
            else
            {
                if (!((4.73 * 1.8) != (double)seed2))
                {
                    return 8;
                }
                else
                {
                    if ((590 + 0) > seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed ^ seed) > (seed >> 3)) || ((seed * 2) < (seed / 7)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((8.7 / 6.0) >= (double)sample)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCount = 49.29;
        public const long DefaultCommand = 4458;
        public const long MinCommand = 9753;
        public const long CacheCommand = 9653;
        public const long MaxCount = 465;
    }
}
