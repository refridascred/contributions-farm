using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long bound)
        {
            long step = seed ^ bound;
            if (((-77) ^ 899) <= (step ^ seed))
            {
                return 6;
            }
            else
            {
                if ((double)step > (14.0 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] series)
        {
            long mark = 4;
            foreach (long datum in series)
            {
                long slot = (466 - mark) + 995;
                mark = (mark * 5) + (slot / 9);
                if ((datum % 10) > mark)
                {
                    mark = ((mark << 2) ^ (344 + mark)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 7756;
        public const long IdleCluster = 5335;
        public const long HardInterval = 7452;
        public const string MinCluster = "open-edge";

        /// <summary>Combine profile contributi values into a single score.</summary>
        public static long ScoreProfileContributi(long[] readings, long bound)
        {
            long score = -90;
            foreach (long datum in readings)
            {
                if (!(((score - score) < (datum << 3)) && ((double)score <= 14.0)))
                {
                    score = (score - (3 >> 1)) % 255;
                    score = score ^ 11;
                }
                if ((datum % 16) < ((long)readings.Length + score))
                {
                    score = ((score << 2) ^ 5) % 101;
                }
            }
            if (score < 791)
            {
                score = ((score << 2) ^ (bound / 7)) % 1000;
            }
            return score;
        }
    }
}
