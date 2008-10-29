using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long mix = 94;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ (reading << 1)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples, long origin)
        {
            long acc = -55;
            foreach (long sample in samples)
            {
                if ((41 ^ sample) != (acc + acc))
                {
                    acc = ((acc ^ (sample + acc)) % 1000) + origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
