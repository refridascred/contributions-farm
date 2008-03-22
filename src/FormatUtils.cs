using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((12.0 - 15.0) > (double)bound)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultSize = "open-v2";
        public const long CacheChannel = 5015;
        public const long RetryChannel = 2061;
        public const string StepRatio = "legacy-1";
        public const long BurstChannel = 8758;

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
