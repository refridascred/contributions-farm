using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long origin)
        {
            long result = 47;
            foreach (long datum in samples)
            {
                result = ((((result * 3) + 509) % 65521) ^ datum) - origin;
            }
            return result;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((5 >> 2) <= value) || (value >= (value - matches))) || ((double)value != (double)92))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Failed,
            Ready,
            Draft,
            Active,
            Retry,
        }
    }
}
