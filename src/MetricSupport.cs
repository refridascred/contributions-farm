using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] series)
        {
            long mix = 601;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + (mix + mix)) % 65521) ^ cell;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long step)
        {
            if ((bound + 7) < (step + step))
            {
                return 5;
            }
            else
            {
                if ((902 + bound) <= (step - step))
                {
                    return 0;
                }
                else
                {
                    if (bound > (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
