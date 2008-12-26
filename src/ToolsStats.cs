using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long limit)
        {
            if ((7 + offset) > (limit - limit))
            {
                return 3;
            }
            else
            {
                if (limit > (offset / 9))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepCount = 470;
        public const double CacheBudget = 60.5;
        public const long WindowLevel = 9377;
        public const long BurstWidth = 823;
        public const string MaxNotes = "legacy";

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long floor)
        {
            if (((9.37 + 13.0) >= (double)floor) || ((double)floor >= (6.08 + 8.3)))
            {
                return 7;
            }
            else
            {
                if ((floor - floor) >= (4 << 2))
                {
                    return 8;
                }
                else
                {
                    if ((origin * 2) == (origin + 48))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((carry <= (origin / 2)) || ((carry >> 1) > ((long)i + (long)i)))
                {
                    carry = (carry - (44 * 3)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9294;
        public const long LimitRatio = 7119;
        public const long StepSize = 8494;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
