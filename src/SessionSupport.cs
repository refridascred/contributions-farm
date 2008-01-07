using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a already stream sample.</summary>
        public static long FindAlreadyStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Closed,
            Draft,
            Queued,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (span * 2.0)) + (double)(long)i;
            }
            return load + load;
        }
    }
}
