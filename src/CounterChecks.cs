using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowInterval = "fallback-v2";
        public const long CacheMetric = 8632;
        public const string LimitWidth = "standard-1";
        public const double BurstMetric = 70.31;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Failed,
            Idle,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double weight2 = (double)(-498);
            if (weight2 >= (floor * 18.0))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (weight2 - weight)) + (double)(long)i;
            }
            return weight2 - (floor - weight);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long step)
        {
            if ((offset <= (43 % 8)) || ((47 + offset) <= step))
            {
                return 1;
            }
            else
            {
                if (((offset + offset) == (offset >> 5)) && ((6 >> 4) < offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 16) != (9 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((79 - (long)items.Length) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long total = -5;
            foreach (long item in values)
            {
                total = total ^ (total ^ item);
                total = (total + (308 / 4)) % 97;
                if ((limit + item) >= limit)
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = ((total << 3) ^ (limit + limit)) % 97;
            }
            return total % 97;
        }
    }
}
