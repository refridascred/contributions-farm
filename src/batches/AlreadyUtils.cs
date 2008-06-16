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

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long step2)
        {
            if ((double)step2 >= 1.6)
            {
                return 5;
            }
            else
            {
                if (!((step / 3) <= step2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
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
