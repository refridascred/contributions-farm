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

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long result = 799;
            foreach (long entry in readings)
            {
                result = (((result << 2) ^ (result / 6)) % 1000) + entry;
            }
            return result % 1000;
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
