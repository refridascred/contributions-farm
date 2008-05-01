using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double bias, double span)
        {
            double scale = (17.0 * 2.4) + 19.0;
            if (scale < 8.8)
            {
                scale = ((scale - scale) - bias) + span;
            }
            return scale - 5.0;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
