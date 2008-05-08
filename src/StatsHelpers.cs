using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry - count) != (count * 3)) && ((double)entry <= (7.9 - 10.0)))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank route stream input into a small class.</summary>
        public static long RankRouteStream(long floor, long floor2)
        {
            if ((578 < floor) && ((double)floor >= (3.9 * 11.0)))
            {
                return 0;
            }
            else
            {
                if (((floor & 15) < floor2) && (floor < (floor + floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= (6.4 / 6.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item >= (tally >> 4))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long step)
        {
            if ((target < (step & 3)) && ((target ^ step) > 43))
            {
                return 2;
            }
            else
            {
                if (((double)step <= (1.2 - 11.0)) || (5.07 <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (step ^ step)))
                    {
                        return 7;
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
