using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two contributi record measurements.</summary>
        public static double AdjustContributiRecord(double gain, double offset)
        {
            double load = (double)(5 * 2);
            return (load - (offset * 2.3)) + gain;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Ready,
            Done,
        }
    }
}
