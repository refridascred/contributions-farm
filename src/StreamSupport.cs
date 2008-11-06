using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            Done,
            Stale,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double load = rate;
            return (load + (double)38) + span;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
