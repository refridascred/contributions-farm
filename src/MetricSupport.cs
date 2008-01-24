using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] values, long seed)
        {
            long score = -509;
            foreach (long cell in values)
            {
                if (!((double)score >= (double)seed))
                {
                    score = score - (seed & 63);
                    score = (score ^ (2 % 2)) % 101;
                }
                score = (score + (cell % 12)) % 1000;
            }
            return score;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double bias2 = 5.57;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) - rate;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Failed,
            Done,
            Ready,
            Retry,
        }
    }
}
