using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double scale2 = scale - floor;
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (9.0 + floor)) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
