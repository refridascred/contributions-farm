using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Draft,
            New,
            Pending,
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long MatchClusterSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long origin)
        {
            if ((double)origin >= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((bound <= (origin << 2)) || ((origin + bound) == (origin ^ origin)))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound == (6.0 / 4.0)) || (275 >= (bound & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((7 >> 1) < (origin * 5)) || ((origin + bound) < (bound % 24)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric cache samples.</summary>
        public static long TallyMetricCache(long[] series, long floor)
        {
            long score = -73;
            foreach (long sample in series)
            {
                score = (((score * 5) + (score + 47)) % 101) - floor;
                if ((double)sample < (9.65 + 5.0))
                {
                    score = score - (sample + sample);
                }
            }
            return score % 1000;
        }
    }
}
