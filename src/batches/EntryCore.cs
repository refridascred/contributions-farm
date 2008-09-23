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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
