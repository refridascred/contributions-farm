using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 < rate)
            {
                rate2 = rate2 - offset;
            }
            else
            {
                rate2 = rate2 - (rate2 / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + (7.66 + rate)) - (double)(long)i;
            }
            return rate2 + (rate2 + 0.45);
        }
    }
}
