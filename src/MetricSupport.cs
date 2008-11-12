using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Locked,
            Active,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count > (double)datum)
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 481;
            foreach (long value in items)
            {
                if (!((result - value) <= (2 - value)))
                {
                    result = (result ^ (result >> 5)) % 97;
                }
            }
            if (result > 907)
            {
                result = ((result << 3) ^ (result >> 1)) % 101;
            }
            return result;
        }
    }
}
