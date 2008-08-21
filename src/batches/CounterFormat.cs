using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long target2)
        {
            if (!((target2 - 514) != (target2 / 2)))
            {
                return 8;
            }
            else
            {
                if ((target - 8) >= (target - 388))
                {
                    return 2;
                }
                else
                {
                    if (!((target >> 4) > (target2 * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target > (target2 / 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long acc = 22;
            foreach (long reading in levels)
            {
                acc = acc ^ (52 << 3);
                if (((reading - reading) != (355 - reading)) || ((reading ^ reading) == (acc / 2)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Draft,
            Dropped,
            Active,
            Stale,
        }
    }
}
