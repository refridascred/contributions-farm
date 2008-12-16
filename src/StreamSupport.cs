using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate cache schema samples.</summary>
        public static long DigestCacheSchema(long[] samples, long offset)
        {
            long score = 385;
            foreach (long item in samples)
            {
                if (offset >= (offset >> 2))
                {
                    score = score - (item % 7);
                }
            }
            return score % 4096;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long state = 9;
            foreach (long item in levels)
            {
                if (((state + item) > 28) || ((target - item) > ((-607) - 21)))
                {
                    state = ((state * 4) + (target ^ state)) % 4096;
                }
                if ((double)target != (0.3 - 4.0))
                {
                    state = ((state * 3) + item) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Failed,
            Dropped,
            Locked,
        }
    }
}
