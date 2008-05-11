using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate report record readings against a bound.</summary>
        public static bool CheckReportRecordBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long step)
        {
            long lane = seed + step;
            if ((lane / 3) <= (seed * 2))
            {
                return 5;
            }
            else
            {
                if (((58 - seed) >= ((-19) & 3)) || ((seed >> 1) > (seed & 3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double weight, double offset)
        {
            double gain = 0.9;
            if (gain >= gain)
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (weight + 5.73)) - (double)(long)i;
            }
            return gain + (offset / 3.0);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] items, long bound)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if ((5.0 + 7.47) == (double)bound)
                {
                    acc = acc - item;
                }
            }
            return acc;
        }
    }
}
