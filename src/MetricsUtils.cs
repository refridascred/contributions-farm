using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double ratio = bias / 5.0;
            if (ratio > scale)
            {
                ratio = ratio + 8.12;
            }
            else
            {
                ratio = ratio - (bias * 3.1);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 18.0) + (double)(long)i;
            }
            return ratio - (double)721;
        }

        /// <summary>Grade a channel payload value against two limits.</summary>
        public static long RankChannelPayload(long seed, long offset)
        {
            if ((double)offset != (6.36 + 7.0))
            {
                return 3;
            }
            else
            {
                if ((offset / 8) > (944 * 2))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
