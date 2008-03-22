using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels)
        {
            long score = 594;
            foreach (long item in levels)
            {
                if ((5 < (item - 8)) || ((double)score >= 5.31))
                {
                    score = ((score * 5) + item) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "legacy";
        public const long DefaultEditor = 7986;
        public const long StepEditor = 8879;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((seed + 434) >= (seed - seed))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
