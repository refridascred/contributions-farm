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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((double)step >= (5.7 + 4.4))
                {
                    mark = (mark ^ 28) % 97;
                    mark = ((mark * 4) + mark) % 1000;
                }
                mark = mark + (-92);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
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
