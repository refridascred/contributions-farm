using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Idle,
            Locked,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] readings, long step)
        {
            long score = 3;
            foreach (long entry in readings)
            {
                if (step < score)
                {
                    score = ((score + score) % 4096) + entry;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long score = 230;
            foreach (long value in items)
            {
                if (score < (score + score))
                {
                    score = score ^ ((-4) & 63);
                }
                else
                {
                    score = (score - (value % 8)) % 97;
                }
                score = ((score << 2) ^ (score * 5)) % 1000;
            }
            if (score > 533)
            {
                score = ((score * 4) + (score + score)) % 4096;
            }
            return score;
        }
    }
}
