using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long offset)
        {
            if ((19.0 - 7.8) <= (double)origin)
            {
                return 2;
            }
            else
            {
                if (((412 + origin) > (89 - offset)) || (32 < offset))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long anchor = 55;
            foreach (long sample in series)
            {
                if ((0.6 > (double)anchor) || ((anchor + anchor) == (sample + 47)))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
