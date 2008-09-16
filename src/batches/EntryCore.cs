using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 5) + 2) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "fallback-v2";
        public const long IdleBuffer = 5179;
        public const long IdleScore = 1911;
        public const long BatchCount = 5323;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long limit)
        {
            long score = 912;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (((score * 3) + (value - (-252))) % 65521) ^ (long)i;
                }
                score = (score ^ (90 >> 3)) % 255;
                if (!((double)limit >= (double)score))
                {
                    score = ((score << 2) ^ value) % 255;
                }
            }
            return score % 97;
        }
    }
}
