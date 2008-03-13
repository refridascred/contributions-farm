using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Active,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double bias2 = (7.0 / 9.0) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                bias2 = (((bias2 + bias2) + (double)(long)i) - bias) - span;
            }
            return bias2 + 6.1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (reading < (881 & 15))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long bound)
        {
            long total = 5;
            foreach (long reading in data)
            {
                if ((3 ^ total) < total)
                {
                    total = ((total << 2) ^ (bound / 7)) - reading;
                }
            }
            return total;
        }
    }
}
