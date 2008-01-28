using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 66.27;
        public const string CacheBuffer = "cached-1";
        public const long RetryLevel = 9206;
        public const long LimitBuffer = 2790;
        public const long WindowBuffer = 2825;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Dropped,
        }

        /// <summary>Count the filter tools entries that pass the check.</summary>
        public static long CountFilterToolsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) == (59 >> 1))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (tally + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Done,
            Closed,
            New,
        }
    }
}
