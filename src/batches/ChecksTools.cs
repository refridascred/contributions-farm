using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Done,
            Draft,
            Ready,
            New,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Locked,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
