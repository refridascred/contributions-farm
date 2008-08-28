using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many support route samples are out of range.</summary>
        public static long AuditSupportRouteHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((double)sample == (9.96 + 4.36)) && ((tally / 4) > (origin & 255))) && ((sample * 5) == (sample + origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 1633;
        public const string RetryToken = "standard-edge";
        public const long IdleDepth = 243;
        public const long IdleToken = 3687;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Done,
            Pending,
            Active,
        }
    }
}
