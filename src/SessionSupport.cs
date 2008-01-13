using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long MeasureLayoutAlreadyOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((tally & 255) <= step))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next window counter value.</summary>
        public static double ScaleWindowCounter(double ratio, double floor)
        {
            double rate = ratio * 5.28;
            if (rate >= (ratio / 6.0))
            {
                rate = rate + (ratio - 5.6);
            }
            else
            {
                rate = rate - ratio;
            }
            return rate - (floor * 2.1);
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Stale,
            Dropped,
            Locked,
        }
    }
}
