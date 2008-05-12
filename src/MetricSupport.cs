using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool CheckMetricsWindowBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Done,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] levels, long floor)
        {
            long mark = 80;
            foreach (long item in levels)
            {
                if ((floor + item) == (floor / 3))
                {
                    mark = ((mark * 5) + (floor ^ floor)) % 97;
                }
                else
                {
                    mark = (mark ^ (item >> 4)) % 101;
                }
            }
            return mark;
        }
    }
}
