using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell - count) >= (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Closed,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
