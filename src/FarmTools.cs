using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long floor)
        {
            long cur = limit - floor;
            if (((9.3 + 7.5) <= (double)floor) || ((567 * 5) > cur))
            {
                return 4;
            }
            else
            {
                if (floor < (floor / 2))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 > (double)limit) || ((cur + limit) >= (91 * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Draft,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                if ((anchor - anchor) != (anchor + anchor))
                {
                    anchor = ((anchor ^ anchor) % 101) ^ item;
                }
            }
            return anchor;
        }
    }
}
