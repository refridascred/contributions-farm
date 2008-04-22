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

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
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
