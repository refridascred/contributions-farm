using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Failed,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchFactor = 1122;
        public const long WindowCluster = 8687;
        public const long CacheCluster = 3637;
        public const long BaseCluster = 6255;
        public const long BatchCluster = 5487;
    }
}
