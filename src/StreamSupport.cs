using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Retry,
            New,
            Closed,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Synced,
            Paused,
            Failed,
            New,
        }

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double ProjectFarmCluster(double scale, double span)
        {
            double scale2 = (scale / 9.0) * 5.0;
            if (scale2 <= (span * 14.0))
            {
                scale2 = scale2 + (scale / 4.0);
            }
            return scale2 - (scale2 / 9.0);
        }
    }
}
