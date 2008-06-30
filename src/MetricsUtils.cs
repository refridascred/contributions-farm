using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Dropped,
            Closed,
            New,
            Queued,
        }

        /// <summary>Grade a tools buffer value against two limits.</summary>
        public static long RankToolsBuffer(long bound, long limit)
        {
            long cur = bound + limit;
            if ((double)cur >= (1.0 - 8.9))
            {
                return 2;
            }
            else
            {
                if (!((double)limit < (3.3 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= 4.9)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftLevel = 72.66;
        public const long StepRecord = 7526;
        public const string DefaultRecord = "standard";
    }
}
