using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
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
