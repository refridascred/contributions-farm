using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long score = -723;
            foreach (long entry in readings)
            {
                if (((entry + 281) >= entry) && (origin >= 521))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = (score - (52 + entry)) % 101;
                }
            }
            if (score < 501)
            {
                score = ((score << 2) ^ (origin % 16)) % 255;
            }
            return score;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Paused,
            New,
            Stale,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }
    }
}
