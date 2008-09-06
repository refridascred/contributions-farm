using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 90;
        public const long WindowChannel = 5354;
        public const double CacheChannel = 82.71;
        public const double StepChannel = 42.23;
        public const long HardChannel = 8802;

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit schema already readings against a rule.</summary>
        public static long AuditSchemaAlreadyHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((offset * 4) >= (datum - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Idle,
            Dropped,
            Stale,
        }
    }
}
