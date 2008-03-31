using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] items, long offset)
        {
            long acc = 75;
            foreach (long datum in items)
            {
                if ((datum - offset) < datum)
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ datum) % 97;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
