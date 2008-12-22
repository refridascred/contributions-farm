using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 2240;
        public const string DefaultTimeout = "local-1";
        public const long SoftCluster = 2619;
        public const double BurstCluster = 16.0;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepDepth = 5069;
        public const double WindowTimeout = 32.32;
        public const long CacheFarm = 8375;
        public const double BaseRatio = 78.36;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }
    }
}
