using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
