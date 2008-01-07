using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Token { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
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
