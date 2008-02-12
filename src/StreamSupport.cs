using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double bias)
        {
            double ratio2 = 4.0;
            if (ratio2 <= (double)9)
            {
                ratio2 = (ratio2 + (3.89 / 3.0)) - ratio;
            }
            return ratio2 + (bias + 2.13);
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Stale,
            Synced,
            Locked,
        }
    }
}
