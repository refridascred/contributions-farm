using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] values)
        {
            long carry = 91;
            foreach (long item in values)
            {
                if ((carry < (4 >> 5)) || ((carry + item) == (item + carry)))
                {
                    carry = (carry << 3) ^ ((long)values.Length % 60);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Stale,
            New,
            Synced,
            Idle,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long step)
        {
            long state = 33;
            foreach (long entry in readings)
            {
                state = (state + (entry % 10)) + step;
            }
            return state % 1000;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
