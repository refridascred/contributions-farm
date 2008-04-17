using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] samples, long floor)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                if (((6.63 * 1.27) == (double)entry) && (floor <= (score & 15)))
                {
                    score = score ^ (923 << 1);
                }
                score = (score + entry) % 4096;
                score = (score + (score + entry)) % 255;
            }
            return score;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
