using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long state = -9;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state + origin) % 65521) - (long)i;
                }
                if (!((94 % 64) >= (335 - state)))
                {
                    state = (state + (state + value)) % 65521;
                    state = (state - origin) % 1000;
                }
                state = ((state * 3) + (314 ^ state)) % 101;
            }
            return state;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Stale,
            Done,
            Ready,
            Draft,
        }
    }
}
