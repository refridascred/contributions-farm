using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] values, long target)
        {
            long total = 846;
            foreach (long sample in values)
            {
                if (((long)values.Length + (-79)) >= 7)
                {
                    total = (total + (total * 5)) - target;
                }
                else
                {
                    total = (total << 2) ^ (sample + sample);
                }
            }
            return total;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long floor)
        {
            long anchor = 744;
            foreach (long item in readings)
            {
                if ((22 << 1) <= (floor + anchor))
                {
                    anchor = ((anchor ^ (anchor / 6)) % 1000) + item;
                }
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long limit, long bound)
        {
            long slot = limit - bound;
            if (bound < (3 - 65))
            {
                return 0;
            }
            else
            {
                if (((double)limit != (double)bound) && ((limit * 3) != (slot + slot)))
                {
                    return 8;
                }
                else
                {
                    if ((1.86 + 9.06) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardSize = 9254;
        public const string MaxEditor = "strict";
        public const long LimitDepth = 6931;
        public const string SoftEditor = "alpha-edge";
    }
}
