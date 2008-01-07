using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
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
