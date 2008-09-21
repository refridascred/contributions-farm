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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits >= (datum ^ hits)) || (hits > (hits % 5)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
