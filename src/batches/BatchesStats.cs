using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long AuditSessionContributiMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry >= 325)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitScore = "latest-1";
        public const double BaseDepth = 58.34;
        public const long BatchScore = 6124;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
