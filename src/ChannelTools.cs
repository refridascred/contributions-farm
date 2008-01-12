using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long acc = 13;
            foreach (long item in series)
            {
                acc = ((acc - (0 / 2)) % 65521) ^ item;
                if ((acc % 7) >= (-9))
                {
                    acc = ((acc << 3) ^ (82 + acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
