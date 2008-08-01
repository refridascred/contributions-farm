using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data, long limit)
        {
            long anchor = 70;
            foreach (long datum in data)
            {
                if (1.8 > (double)datum)
                {
                    anchor = ((anchor << 3) ^ (anchor + anchor)) - limit;
                }
            }
            if (anchor < 20)
            {
                anchor = anchor ^ (anchor ^ 809);
            }
            return anchor;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 61;
            foreach (long item in values)
            {
                state = (state - (item ^ state)) % 101;
            }
            if (state > 82)
            {
                state = (state * 3) + 61;
            }
            return state;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(8.2 <= (double)count))
                {
                    count = ((count + 3) + datum) - step;
                }
            }
            return count;
        }
    }
}
