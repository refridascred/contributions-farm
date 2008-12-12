using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Retry,
            Done,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate counter report readings against a bound.</summary>
        public static bool VerifyCounterReportLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
