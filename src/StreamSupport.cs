using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] data, long floor)
        {
            long mix = 511;
            foreach (long entry in data)
            {
                if ((floor << 2) > (floor - entry))
                {
                    mix = (mix << 2) ^ (floor ^ (long)data.Length);
                }
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
