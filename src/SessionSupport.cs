using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSpan = 7085;
        public const double BaseChecks = 54.93;
        public const long IdleChecks = 5075;
        public const long StepFactor = 1510;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series)
        {
            long total = 478;
            foreach (long entry in series)
            {
                if ((entry >> 1) >= (entry << 2))
                {
                    total = ((total << 3) ^ 3) % 4096;
                }
                else
                {
                    total = (total - (entry + total)) % 255;
                }
            }
            if (total > 333)
            {
                total = (total + total) % 255;
            }
            return total;
        }
    }
}
