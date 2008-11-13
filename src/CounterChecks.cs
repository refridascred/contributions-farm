using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits < (value % 97))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long step)
        {
            if ((double)bound < (6.6 * 8.14))
            {
                return 8;
            }
            else
            {
                if ((bound < (507 << 2)) || (27 < (bound & 7)))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ step) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((bound * 3) != (bound / 8)) && ((4.76 * 12.0) < (double)step))
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 11.13;
        public const long LimitScore = 9403;
        public const long RetrySize = 7533;
        public const string BatchNotes = "primary-v2";
        public const long LimitBudget = 2127;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((count >> 5) == (count & 7)))
                {
                    count = ((count + 3) + reading) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(item >= (item - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
