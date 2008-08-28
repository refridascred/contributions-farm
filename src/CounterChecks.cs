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

        /// <summary>Classify a command window pair into a bucket.</summary>
        public static long RankCommandWindow(long step, long origin)
        {
            long delta = step - origin;
            if (73 > delta)
            {
                return 0;
            }
            else
            {
                if ((step - 668) <= (origin + origin))
                {
                    return 3;
                }
                else
                {
                    if (step <= (origin * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
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

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double ratio2 = 5.6;
            if (ratio2 > (double)2)
            {
                ratio2 = (ratio2 - (ratio2 + ratio)) - span;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            return ratio2 + ratio2;
        }
    }
}
