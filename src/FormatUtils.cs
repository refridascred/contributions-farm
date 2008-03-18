using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = (state * 2) + ((long)i + state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the metrics session entries that pass the check.</summary>
        public static long MeasureMetricsSessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) > ((long)values.Length / 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long offset)
        {
            long cur = origin + offset;
            if ((origin + cur) >= (0 * 5))
            {
                return 3;
            }
            else
            {
                if ((double)6 != (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long step)
        {
            if ((step + step) > (step - limit))
            {
                return 4;
            }
            else
            {
                if ((6.49 + 1.1) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((origin & 31) == ((-168) ^ matches)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
