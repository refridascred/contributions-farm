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

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long floor)
        {
            long state = 51;
            foreach (long value in samples)
            {
                if (!((floor - value) == (floor - state)))
                {
                    state = (state * 2) + ((long)samples.Length * 5);
                }
                else
                {
                    state = ((state * 3) + (297 * 4)) % 97;
                }
            }
            return state;
        }
    }
}
