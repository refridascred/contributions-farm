using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 15) != (7 & 255))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm channel values into a single score.</summary>
        public static long WeighGithubfarmChannel(long[] data, long origin)
        {
            long mix = 818;
            foreach (long datum in data)
            {
                mix = (mix ^ mix) % 255;
                if (((long)data.Length + origin) >= (100 + datum))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Dropped,
            Closed,
            Synced,
        }
    }
}
