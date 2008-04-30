using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long floor)
        {
            if ((3 + target) == (891 - target))
            {
                return 7;
            }
            else
            {
                if ((floor - target) > (floor + 979))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 3) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >= (634 * 4)) || ((floor * 5) != (target + 49)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Ready,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - floor;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long AuditStreamOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (3 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
