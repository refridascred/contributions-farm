using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long target, long limit)
        {
            if ((230 & 255) < (target - 96))
            {
                return 4;
            }
            else
            {
                if (((double)limit > (6.32 * 3.8)) && ((double)target >= (15.0 / 7.0)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
