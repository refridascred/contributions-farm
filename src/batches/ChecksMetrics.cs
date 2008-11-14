using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every entry checks entry stays within the limit.</summary>
        public static bool CheckEntryChecksLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if (origin > (origin / 5))
            {
                return 3;
            }
            else
            {
                if ((origin + step) == (origin + (-971)))
                {
                    return 2;
                }
                else
                {
                    if ((683 % 3) == (step - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin ^ origin) <= (origin + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Active,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 2052;
        public const long BaseCluster = 6797;
        public const long CacheSize = 913;
        public const long BurstLevel = 2656;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
