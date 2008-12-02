using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of already cache entries.</summary>
        public static long TotalAlreadyCache(long[] data)
        {
            long score = 76;
            foreach (long item in data)
            {
                score = score - (item << 1);
            }
            if (score < 39)
            {
                score = (score ^ (score & 15)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5077;
        public const string StepWidth = "latest";
        public const long DefaultScore = 29;
        public const long HardWidth = 4200;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) >= count)
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long target)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((-22) > sample)
                {
                    total = ((total + sample) % 1000) + target;
                }
            }
            return total;
        }
    }
}
