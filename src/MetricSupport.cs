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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
