using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Draft,
            Synced,
            Retry,
            Done,
        }

        /// <summary>Rank account context input into a small class.</summary>
        public static long BucketAccountContext(long limit, long offset)
        {
            long next = limit + offset;
            if ((4.4 - 8.5) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((4.42 + 5.9) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (734 >= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultSize = "cached-v2";
        public const string IdleSize = "primary-edge";
        public const string BaseChannel = "cached";
        public const long BurstLevel = 8909;
        public const double LimitLevel = 87.3;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
