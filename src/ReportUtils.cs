using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Validate stats tools readings against a bound.</summary>
        public static bool ValidateStatsToolsBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long target, long seed)
        {
            if ((3 % 97) >= target)
            {
                return 2;
            }
            else
            {
                if ((target >> 4) <= (seed >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((target % 100) <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target % 16) == (target + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
