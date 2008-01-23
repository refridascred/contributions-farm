using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheTimeout = 14.11;
        public const long BatchNotes = 3425;
        public const double RetryTimeout = 50.03;
    }
}
