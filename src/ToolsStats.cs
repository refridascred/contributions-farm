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

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double gain = floor;
            if (gain <= scale)
            {
                gain = gain + (gain / 4.0);
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + floor;
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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long step)
        {
            if (4 > (step & 3))
            {
                return 1;
            }
            else
            {
                if ((double)seed < (2.3 - 18.0))
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
}
