using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of queue githubfarm entries.</summary>
        public static long CombineQueueGithubfarm(long[] series)
        {
            long state = 7;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length > (3.86 * 10.0))
                {
                    state = (state * 5) + (cell - state);
                }
            }
            if (state > 36)
            {
                state = (state + (5 + state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            New,
            Pending,
            Locked,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
