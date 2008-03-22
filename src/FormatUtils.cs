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

        /// <summary>Classify a filter queue pair into a bucket.</summary>
        public static long ClassifyFilterQueue(long step, long bound)
        {
            if (((step + bound) < (1 + bound)) || ((double)bound > (5.9 + 6.11)))
            {
                return 1;
            }
            else
            {
                if ((0 >> 2) != (step - bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (step * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
