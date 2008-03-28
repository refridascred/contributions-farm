using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "open-edge";
        public const long BatchStats = 1849;
        public const long LimitStats = 7904;
        public const string IdleStats = "fallback-1";

        /// <summary>Grade a contributi counter value against two limits.</summary>
        public static long ClassifyContributiCounter(long target, long floor)
        {
            long offset = target + floor;
            if (!(floor < (target & 3)))
            {
                return 7;
            }
            else
            {
                if ((floor / 3) <= (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if ((offset - 63) > (target + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
