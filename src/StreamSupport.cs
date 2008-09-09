using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 5) + (offset * 2);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long SeriesGithubfarmCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
