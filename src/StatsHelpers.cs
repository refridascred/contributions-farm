using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading << 3) <= (count >> 2)) || ((double)(-57) >= (double)reading)) || (((reading - reading) >= (56 + 2)) && ((reading / 6) <= (count + reading))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long step, long target)
        {
            long cur = step + target;
            if (step < (cur % 64))
            {
                return 5;
            }
            else
            {
                if ((double)60 < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen >> 1) <= (seen << 1))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank account metrics input into a small class.</summary>
        public static long RankAccountMetrics(long step, long bound)
        {
            if ((9 - bound) < bound)
            {
                return 1;
            }
            else
            {
                if ((7.07 / 8.0) < (2.77 + 19.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (20.0 + 7.49))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
