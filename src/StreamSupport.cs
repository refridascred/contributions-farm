using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7371;
        public const string CacheInterval = "legacy-v2";
        public const long BatchTimeout = 9583;
        public const long CacheEntry = 2157;
        public const string HardRatio = "latest-v2";

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            long offset = limit ^ target;
            if (((double)target > (12.0 * 6.0)) && (target <= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((double)target <= (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((9.3 + 3.47) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset & 255) > target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            Ready,
            Queued,
            Dropped,
        }
    }
}
