using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((result ^ (long)i) < result)
                {
                    result = (result ^ (long)i) % 65521;
                }
                result = result + (bound * 4);
                result = ((result * 5) + (long)i) % 101;
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
