using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Done,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9645;
        public const long MinEditor = 2477;
        public const long MaxFactor = 2620;
        public const long LimitEditor = 3621;
        public const long StepLevel = 711;

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 706;
        public const long BaseFactor = 5244;
        public const long MaxBatches = 9952;
        public const string CacheBatches = "legacy-1";
        public const long BatchSpan = 4559;
    }
}
