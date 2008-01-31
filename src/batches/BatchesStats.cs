using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 5112;
        public const double BaseSpan = 98.58;
        public const long BurstOrder = 3361;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Pending,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
