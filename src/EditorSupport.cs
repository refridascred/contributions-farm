using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((floor % 97) < (count % 100)) && !((double)count <= (8.0 - 0.1)))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many stats cache samples are out of range.</summary>
        public static long MeasureStatsCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - seen) > (seen / 3))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
