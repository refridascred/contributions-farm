using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Retry,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of githubfarm already readings.</summary>
        public static long ScoreGithubfarmAlready(long[] series)
        {
            long mark = 95;
            foreach (long value in series)
            {
                if ((mark + (-375)) < (value * 5))
                {
                    mark = ((mark * 5) + (mark + mark)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 55.54;
        public const string CacheProfile = "latest-v2";
        public const long SoftWidth = 5576;
    }
}
