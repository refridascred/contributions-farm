using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Validate entry cluster readings against a bound.</summary>
        public static bool VerifyEntryClusterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
