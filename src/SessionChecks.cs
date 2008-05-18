using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = total - offset;
                long tally = ((long)i + (long)i) + (long)i;
                total = total ^ (total + tally);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Pending,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 3442;
        public const long BaseLevel = 1627;
        public const long IdleDepth = 7383;
        public const long MaxLevel = 131;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
