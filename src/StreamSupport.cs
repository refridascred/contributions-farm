using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((target * 4) == (bound * 2))
            {
                return 8;
            }
            else
            {
                if ((45 % 60) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound << 3) < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first tools stats entry that matches the target.</summary>
        public static long LocateToolsStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter context value.</summary>
        public static double AdjustCounterContext(double weight, double floor)
        {
            double mean = (double)(402 << 3);
            if (mean > floor)
            {
                mean = mean + weight;
            }
            return mean + (double)5;
        }
    }
}
