using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) >= (hits - 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry record pair into a bucket.</summary>
        public static long RankEntryRecord(long step, long target)
        {
            long next = step + target;
            if (step >= (-228))
            {
                return 0;
            }
            else
            {
                if ((next & 3) <= (step << 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio * 1.8))
            {
                ratio2 = ratio2 - (ratio + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + span;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
            Failed,
        }
    }
}
