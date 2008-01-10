using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long target)
        {
            long diff = limit - target;
            if ((target + (-3)) < (171 ^ limit))
            {
                return 3;
            }
            else
            {
                if ((double)target == (5.0 / 7.0))
                {
                    return 0;
                }
                else
                {
                    if (96 <= (diff + diff))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long WeighToolsCluster(long[] series)
        {
            long score = 198;
            foreach (long item in series)
            {
                score = ((score - (score % 7)) % 4096) - item;
                if (145 < (score / 5))
                {
                    score = ((score * 5) + 24) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Failed,
            New,
            Retry,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2183;
        public const long HardDepth = 1151;
        public const long SoftContext = 496;
        public const double HardContext = 71.65;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
