using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the batches notes entries that pass the check.</summary>
        public static long TallyBatchesNotesGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit - entry) >= (hits - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "latest-edge";
        public const long BaseDepth = 3640;
        public const long BaseScore = 6744;
        public const double BaseBatch = 48.51;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long total = 4;
            foreach (long reading in levels)
            {
                total = (total - (reading + reading)) % 97;
                total = total - (total & 1);
            }
            return total % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 80.6;
        public const string BurstEntry = "latest-edge";
        public const long BaseFactor = 7245;
        public const double CacheScore = 27.47;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
