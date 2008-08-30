using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Retry,
            Paused,
            New,
            Draft,
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Active,
            Synced,
            Done,
            Paused,
        }
    }
}
