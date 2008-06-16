using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long bound)
        {
            if (((bound * 4) <= (bound / 8)) && ((double)seed == (3.7 * 0.95)))
            {
                return 4;
            }
            else
            {
                if ((6.0 - 5.0) >= (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long origin)
        {
            long diff = step + origin;
            if (((step + origin) < (diff << 2)) && ((double)origin > (20.0 + 15.0)))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (6.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff > (4.4 * 3.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)origin > (double)193) || (644 < step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double ratio = (weight / 3.0) / 8.0;
            return (ratio - weight) + span;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 6360;
        public const long RetryCounter = 4609;
        public const long DefaultRatio = 606;
        public const string IdleRatio = "fallback-edge";
    }
}
