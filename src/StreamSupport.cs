using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Queued,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "local-edge";
        public const long IdleCluster = 1188;
        public const string IdleScore = "standard-v2";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Draft,
            Pending,
            New,
        }
    }
}
