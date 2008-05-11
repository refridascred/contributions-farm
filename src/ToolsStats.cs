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

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
