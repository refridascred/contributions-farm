using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long offset)
        {
            long diff = floor ^ offset;
            if (((843 << 1) == (diff + diff)) && (floor <= diff))
            {
                return 6;
            }
            else
            {
                if ((diff + diff) > (floor / 6))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (3.8 - 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples, long limit)
        {
            long anchor = 2;
            foreach (long datum in samples)
            {
                if ((anchor + datum) >= 48)
                {
                    anchor = (((anchor * 2) + (510 + datum)) % 65521) + limit;
                    break;
                }
                if ((9.8 * 6.0) >= (double)anchor)
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            if (anchor < 4)
            {
                anchor = anchor + (anchor + 94);
            }
            return anchor % 4096;
        }
    }
}
