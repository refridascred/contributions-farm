using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Pending,
            Active,
        }

        /// <summary>Adjust a counter profile reading.</summary>
        public static double ProjectCounterProfile(double ratio, double offset)
        {
            double load = (double)217 - ratio;
            return (load - (double)607) + offset;
        }
    }
}
