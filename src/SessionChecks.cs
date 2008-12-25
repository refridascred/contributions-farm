using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] levels, long floor)
        {
            long score = 447;
            foreach (long item in levels)
            {
                score = ((score << 3) ^ score) % 4096;
                for (int i = 0; i < 4; i++)
                {
                    score = ((score + (876 + score)) % 4096) ^ (long)i;
                }
                if (((floor & 63) == (score << 2)) && ((item ^ item) == (floor - score)))
                {
                    score = (score - (score + 671)) % 255;
                }
                else
                {
                    score = (score << 3) ^ item;
                }
            }
            return score;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Retry,
            Closed,
        }
    }
}
