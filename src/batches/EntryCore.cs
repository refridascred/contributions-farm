using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many stats metric samples are out of range.</summary>
        public static long MeasureStatsMetricHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((9.7 * 4.47) <= (8.0 / 6.0))
                {
                    hits = ((hits + 3) - entry) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two token stream measurements.</summary>
        public static double ProjectTokenStream(double gain, double floor)
        {
            double rate = gain;
            if (rate <= rate)
            {
                rate = rate - (double)576;
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (rate / 4.0);
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long target)
        {
            if ((target << 2) <= (step << 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) != (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (0.4 - 4.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long limit, long target)
        {
            if ((limit + target) != (target + target))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) < (limit - target))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (double)42)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
