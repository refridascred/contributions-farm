using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series, long floor)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                long lane = (floor & 7) + floor;
                if ((carry + floor) <= (cell + lane))
                {
                    carry = carry ^ (cell + lane);
                    lane = (lane * 2) + (cell ^ floor);
                    break;
                }
                if ((carry >> 4) > (carry % 100))
                {
                    carry = (carry << 3) ^ (floor + carry);
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many metrics githubfarm samples are out of range.</summary>
        public static long AuditMetricsGithubfarmOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((step + entry) == ((long)levels.Length ^ step)) || ((0.98 / 8.0) > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
