using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((3.82 - 5.9) >= (double)offset)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 34.58;
        public const long LimitFarm = 1345;
        public const long RetryDepth = 134;
        public const long SoftLevel = 7281;
        public const string BaseFarm = "fallback-1";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Pending,
            Paused,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long score = 90;
            foreach (long entry in series)
            {
                if ((score - 1) < (entry + bound))
                {
                    score = score - (bound & 127);
                }
                else
                {
                    score = (score - (entry & 127)) % 97;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a route filter sample.</summary>
        public static long SeekRouteFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
