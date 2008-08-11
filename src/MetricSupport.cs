using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of farm batches readings.</summary>
        public static long PairFarmBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long bound, long limit)
        {
            if ((bound / 4) > limit)
            {
                return 6;
            }
            else
            {
                if ((double)bound < (20.0 * 10.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the editor filter entries that pass the check.</summary>
        public static long CountEditorFilterMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((floor ^ reading) == (reading / 6)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
