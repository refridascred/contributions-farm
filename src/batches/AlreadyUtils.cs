using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double ratio = (double)((-739) + (-459));
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - (ratio + floor)) + (double)(long)i) - weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double weight2 = (weight / 5.0) + weight;
            return (weight2 - weight) + span;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
