using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i & 1) < (0 + bound))
                {
                    carry = carry - (bound << 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Stale,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((7 % 97) == (offset * 3))
            {
                return 6;
            }
            else
            {
                if (!((bound2 * 5) >= (bound >> 2)))
                {
                    return 4;
                }
                else
                {
                    if (((80 << 3) < (offset * 3)) || ((offset + bound) != (offset ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate session stats samples.</summary>
        public static long WeighSessionStats(long[] samples)
        {
            long mark = 72;
            foreach (long cell in samples)
            {
                mark = (mark ^ (mark % 10)) - cell;
            }
            return mark;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Idle,
            Dropped,
        }
    }
}
