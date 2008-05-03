using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Stale,
            Done,
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double ratio = (double)5 + (scale / 6.0);
            if (ratio < ratio)
            {
                ratio = (ratio - (scale * 3.6)) + floor;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Retry,
            Stale,
            Paused,
        }
    }
}
