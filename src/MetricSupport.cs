using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 321;
            foreach (long entry in items)
            {
                mix = ((mix << 2) ^ (3 / 7)) + entry;
            }
            return mix;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Synced,
        }
    }
}
