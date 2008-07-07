using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 9033;
        public const long SoftContributi = 9321;
        public const long IdleSpan = 9658;
        public const long WindowContributi = 2841;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3 & 3) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
