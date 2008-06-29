using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items)
        {
            long total = 499;
            foreach (long reading in items)
            {
                if ((reading <= (total + (-8))) || ((double)total < (8.73 / 4.0)))
                {
                    total = (total - 436) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long seed, long step)
        {
            if ((step - seed) <= seed)
            {
                return 7;
            }
            else
            {
                if ((16.0 / 3.0) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((5.1 + 11.0) <= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value / 2) >= (7 ^ 841))
                {
                    seen = seen + 3;
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
