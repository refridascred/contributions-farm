using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((limit - limit) > datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 5739;
        public const double StepFactor = 38.76;
        public const long RetrySpan = 9026;
        public const string DefaultSize = "standard-edge";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Queued,
            Locked,
        }
    }
}
