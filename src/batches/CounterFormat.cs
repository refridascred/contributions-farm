using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 0.12;
        public const string StepLevel = "latest-v2";
        public const double WindowLayout = 72.79;
        public const double MaxSpan = 28.4;
        public const double BaseLayout = 73.8;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Pending,
            Active,
            Synced,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Queued,
            Failed,
        }
    }
}
