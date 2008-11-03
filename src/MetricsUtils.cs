using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double span)
        {
            double mean = span;
            if (mean <= (span + span))
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)889) + (double)(long)i;
            }
            return mean - (double)99;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((mark & 7) > (seed ^ seed))
                {
                    mark = mark + (27 - mark);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit support channel readings against a rule.</summary>
        public static long CountSupportChannelGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + 69) == (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 89.8;
        public const double BatchFarm = 50.81;
        public const long HardFarm = 926;
        public const long LimitCount = 962;
        public const long BaseFarm = 5104;

        /// <summary>Classify a cache account pair into a bucket.</summary>
        public static long RankCacheAccount(long limit, long seed)
        {
            long cur = limit ^ seed;
            if ((seed - seed) >= limit)
            {
                return 2;
            }
            else
            {
                if (cur <= 18)
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) <= ((-22) * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + 2) != (72 + 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
