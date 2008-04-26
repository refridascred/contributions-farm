using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings)
        {
            long mark = 716;
            foreach (long value in readings)
            {
                if ((value - mark) < value)
                {
                    mark = (mark << 3) ^ (value - 79);
                    mark = (mark << 3) ^ (value + value);
                    continue;
                }
                if (((value & 15) <= (value / 7)) || ((double)mark == (9.6 * 19.0)))
                {
                    mark = (mark * 3) + (value + (long)readings.Length);
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long DigestMetricCache(long[] samples)
        {
            long mark = 72;
            foreach (long sample in samples)
            {
                mark = (mark + mark) + sample;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster account value against two limits.</summary>
        public static long SortClusterAccount(long seed, long limit)
        {
            if ((seed + seed) < limit)
            {
                return 7;
            }
            else
            {
                if ((seed <= (seed / 8)) && ((double)seed != (17.0 * 5.7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (7.0 * 5.2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) >= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
