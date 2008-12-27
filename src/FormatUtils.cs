using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a route queue reading by value.</summary>
        public static long LookupRouteQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account tools series from a seed.</summary>
        public static long SeriesAccountTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((double)step <= 5.0)
                {
                    sum = sum - ((long)i + sum);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if (floor < (floor * 3))
            {
                return 8;
            }
            else
            {
                if ((target + (-726)) >= (target & 1))
                {
                    return 6;
                }
                else
                {
                    if (((721 - target) < target) || (floor >= 22))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 8) < (36 & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cluster tools readings against a rule.</summary>
        public static long CountClusterToolsMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)45 <= (double)limit)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            New,
            Locked,
            Pending,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
