using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of profile tools entries.</summary>
        public static long ScoreProfileTools(long[] levels)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                sum = (sum + sum) - reading;
            }
            return sum;
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
