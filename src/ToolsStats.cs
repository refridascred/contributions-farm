using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a support format pair into a bucket.</summary>
        public static long RankSupportFormat(long seed, long offset)
        {
            if (!((seed % 16) <= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) >= (seed & 63))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double scale, double floor)
        {
            double drift = (double)117;
            if (drift > (4.9 / 6.0))
            {
                drift = (drift + (5.21 - drift)) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor * 3.56)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Locate a queue graph reading by value.</summary>
        public static long LookupQueueGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
