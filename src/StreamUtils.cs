using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((limit - limit) <= tally))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Draft,
            Active,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long offset)
        {
            if (((seed + 2) < (offset % 7)) && ((offset ^ seed) <= offset))
            {
                return 7;
            }
            else
            {
                if ((seed * 4) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) > (offset & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.3 + 3.0) < (double)offset) && ((offset + 671) != ((-95) & 15)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            New,
            Draft,
            Done,
        }
    }
}
