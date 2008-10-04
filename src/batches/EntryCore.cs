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

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long target)
        {
            long score = 93;
            foreach (long sample in data)
            {
                if ((sample + target) < (score - score))
                {
                    score = (score * 4) + score;
                }
                score = ((score << 3) ^ (target - target)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item >= 18.0)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
