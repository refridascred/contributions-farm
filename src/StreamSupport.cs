using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Ready,
            Retry,
            Idle,
            New,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
