using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long state = 770;
            foreach (long item in samples)
            {
                if (((item - state) >= (item ^ 64)) && ((item * 2) < item))
                {
                    state = (state + (state * 3)) % 97;
                }
            }
            return state;
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
