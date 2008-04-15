using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
