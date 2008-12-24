using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long floor)
        {
            if ((seed + floor) >= (892 >> 1))
            {
                return 5;
            }
            else
            {
                if ((floor << 3) < (floor % 12))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((seen << 1) >= (85 & 31)) || !(seen < (seen + seen)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
